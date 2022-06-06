﻿using DoAnPBL3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnPBL3
{
    public partial class FormIdentify : Form
    {
        private readonly string accountUsername;
        private readonly string password;
        private readonly string id;
        private readonly string nameAuthor;
        public FormIdentify(string accountUsername, string password, string id, string nameAuthor = "")
        {
            InitializeComponent();
            this.accountUsername = accountUsername;
            this.password = password;
            this.id = id;
            this.nameAuthor = nameAuthor;
        }

        private void FormIdentify_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        public void Alert(string msg, Form_Alert.EnmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.ShowAlert(msg, type);
        }

        private void RjbtnOK_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text.Trim() == "")
                RJMessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (password != tbConfirmPass.Text)
                RJMessageBox.Show("Sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    var user = context.Accounts.Find(accountUsername);
                    // Admin
                    if (user.Role)
                    {
                        Employee employee = context.Employees.Find(id);
                        context.Employees.Remove(employee);
                        context.SaveChanges();
                        Alert("Xóa nhân viên thành công", Form_Alert.EnmType.Success);
                        Close();
                    }
                    // Employee
                    else
                    {
                        // Xoa sach
                        if (nameAuthor == "")
                        {
                            Book book = context.Books.Find(id);
                            context.Books.Remove(book);
                            context.SaveChanges();
                            Alert("Xóa mặt hàng sách thành công", Form_Alert.EnmType.Success);
                            Close();
                        }
                        // Them moi tac gia
                        else
                        {
                            Author newAuthor;
                            var lastAuthor = context.Authors
                                .OrderBy(auth => auth.ID_Author)
                                .Select(auth => new { auth.ID_Author })
                                .ToList()
                                .LastOrDefault();
                            if (lastAuthor == null)
                                newAuthor = new Author(1, nameAuthor, "");
                            else
                                newAuthor = new Author(lastAuthor.ID_Author + 1, nameAuthor, "");
                            context.Authors.Add(newAuthor);
                            context.SaveChanges();
                            Close();
                        }
                    }
                }
            }
        }

        private void RjbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                rjbtnOK.PerformClick();
                e.Handled = true;
            }
        }
    }
}