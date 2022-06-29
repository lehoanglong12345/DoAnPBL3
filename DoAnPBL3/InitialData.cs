﻿using DoAnPBL3.Models;
using DoAnPBL3.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnPBL3
{
    public class InitialData : CreateDatabaseIfNotExists<BookStoreContext>
    {
        public static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\";
        public static readonly string pathAdministratorMan = "Img\\Icon\\administrator-man.png";
        public static readonly string pathAdministratorWoman = "Img\\Icon\\administrator_woman2.png";
        public static readonly string pathEmployeeMan = "Img\\Icon\\male employee.png";
        public static readonly string pathEmployeeWoman = "Img\\Icon\\female employee.png";
        protected override void Seed(BookStoreContext context)
        {
            context.Accounts.AddRange(new Account[]
            {
                // Admin
                new Account {Username = "lehoanglong", Password = "lehoanglong",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "nguyenkhacthai", Password = "nguyenkhacthai",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "daothuytrang", Password = "daothuytrang",
                    Role = true, Avatar = pathAdministratorWoman},
                new Account {Username = "nguyentrongnghia", Password = "nguyentrongnghia",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "lyvantanh", Password = "lyvantanh",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "ngoducquockhanh", Password = "ngoducquockhanh",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "travanthien", Password = "travanthien",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "letronghoangminh", Password = "letronghoangminh",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "leviettungduong", Password = "leviettungduong",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "nguyentrongsang", Password = "nguyentrongsang",
                    Role = true, Avatar = pathAdministratorMan},
                new Account {Username = "nguyenvanhoangnhan", Password = "nguyenvanhoangnhan",
                    Role = true, Avatar = pathAdministratorMan},
                // Employee
                new Account {Username = "phamtienhuu", Password = "phamtienhuu",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "nguyenbatuan", Password = "nguyenbatuan",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "tranchinhhuy", Password = "tranchinhhuy",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "dangvanphuocnguyen", Password = "dangvanphuocnguyen",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "nguyenquangkhai", Password = "nguyenquangkhai",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "phamhoangson", Password = "phamhoangson",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "ngotandung", Password = "ngotandung",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "nguyenvankhoa", Password = "nguyenvankhoa",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "levanthanh", Password = "levanthanh",
                    Role = false, Avatar = pathEmployeeMan},
                new Account {Username = "trankhanhphuong", Password = "trankhanhphuong",
                    Role = false, Avatar = pathEmployeeWoman},
                new Account {Username = "lethihuyentrang", Password = "lethihuyentrang",
                    Role = false, Avatar = pathEmployeeWoman},
            });

            context.Admins.AddRange(new Admin[]
            {
                new Admin {ID_Admin = "AD0001", FullNameAdmin = "Lê Hoàng Long", Email = "lelong.ll32@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000001", ID_Card = "201800001", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "lehoanglong"},

                new Admin {ID_Admin = "AD0002", FullNameAdmin = "Nguyễn Khắc Thái", Email = "nguyenkhacthai@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000002", ID_Card = "201800002", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenkhacthai"},

                new Admin {ID_Admin = "AD0003", FullNameAdmin = "Đào Thủy Trang", Email = "daothuytrang@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nữ", Phone = "0905000003", ID_Card = "201800003", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "daothuytrang"},

                new Admin {ID_Admin = "AD0004", FullNameAdmin = "Lý Văn Tánh", Email = "lyvantanh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000001", ID_Card = "201800004", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "lyvantanh"},

                new Admin {ID_Admin = "AD0005", FullNameAdmin = "Ngô Đức Quốc Khánh", Email = "ngoducquockhanh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000004", ID_Card = "201800005", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "ngoducquockhanh"},

                new Admin {ID_Admin = "AD0006", FullNameAdmin = "Trà Văn Thiên", Email = "travanthien@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000005", ID_Card = "201800006", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "travanthien"},

                new Admin {ID_Admin = "AD0007", FullNameAdmin = "Lê Trọng Hoàng Minh", Email = "letronghoangminh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000006", ID_Card = "201800007", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "letronghoangminh"},

                new Admin {ID_Admin = "AD0008", FullNameAdmin = "Lê Viết Tùng Dương", Email = "leviettungduong@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000007", ID_Card = "201800008", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "leviettungduong"},

                new Admin {ID_Admin = "AD0009", FullNameAdmin = "Nguyễn Trọng Sang", Email = "nguyentrongsang@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000008", ID_Card = "201800009", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyentrongsang"},

                new Admin {ID_Admin = "AD0010", FullNameAdmin = "Nguyễn Văn Hoàng Nhân", Email = "nguyenvanhoangnhan@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000009", ID_Card = "201800010", Address = "Đà Nẵng",
                    Avatar = null, AccountUsername = "nguyenvanhoangnhan"},
            });

            context.Employees.AddRange(new Employee[]
            {
                new Employee {ID_Employee = "E0000", FullNameEmployee = "Phạm Tiến Hữu", Email = "phamtienhuu@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000001", Id_Card = "201800001", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\chongyun.png", AccountUsername = "phamtienhuu"},

                new Employee {ID_Employee = "E0001", FullNameEmployee = "Nguyễn Bá Tuấn", Email = "nguyenbatuan@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000002", Id_Card = "201800002", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\xiao.png", AccountUsername = "nguyenbatuan"},

                new Employee {ID_Employee = "E0002", FullNameEmployee = "Trần Chính Huy", Email = "tranchinhhuy@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000003", Id_Card = "201800003", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\diluc.png", AccountUsername = "tranchinhhuy"},

                new Employee {ID_Employee = "E0003", FullNameEmployee = "Nguyễn Quang Khải", Email = "nguyenquankhai@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000004", Id_Card = "201800004", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\xingqiu.png", AccountUsername = "nguyenquangkhai"},

                new Employee {ID_Employee = "E0004", FullNameEmployee = "Phạm Hoàng Sơn", Email = "phamhoangson@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000005", Id_Card = "201800005", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\heizou.png", AccountUsername = "phamhoangson"},

                new Employee {ID_Employee = "E0005", FullNameEmployee = "Ngô Tấn Dũng", Email = "ngotandung@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000006", Id_Card = "201800006", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\thoma.png", AccountUsername = "ngotandung"},

                new Employee {ID_Employee = "E0006", FullNameEmployee = "Nguyễn Văn Khoa", Email = "nguyenvankhoa@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000007", Id_Card = "201800007", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\bennett.png", AccountUsername = "nguyenvankhoa"},

                new Employee {ID_Employee = "E0007", FullNameEmployee = "Lê Văn Thành", Email = "levanthanh@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nam", Phone = "0905000008", Id_Card = "201800008", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\ayato.png", AccountUsername = "levanthanh"},

                new Employee {ID_Employee = "E0008", FullNameEmployee = "Trần Khánh Phương", Email = "trankhanhphuong@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nữ", Phone = "0905000009", Id_Card = "201800009", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\hutao.png", AccountUsername = "trankhanhphuong"},

                new Employee {ID_Employee = "E0009", FullNameEmployee = "Lê Thị Huyền Trang", Email = "lethihuyentrang@gmail.com",
                    DateOfBirth = new DateTime(2000, 01, 01), StartDate = new DateTime(2020, 01, 01), EndDate = null,
                    Gender = "Nữ", Phone = "0905000010", Id_Card = "201800010", Address = "Đà Nẵng",
                    Avatar = "Img\\GI\\keqing.png", AccountUsername = "lethihuyentrang"},
            });

            context.Customers.AddRange(new Customer[]
            {
                new Customer {ID_Customer = "KH0000", FullNameCustomer = "Nguyễn Thị Thảo Ly",
                    Gender = "Nữ", Phone = "0905000001", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0001", FullNameCustomer = "Vũ Thanh Tùng",
                    Gender = "Nam", Phone = "0905000002", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0002", FullNameCustomer = "Nguyễn Thị Mai Hương",
                    Gender = "Nữ", Phone = "0905000003", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0003", FullNameCustomer = "Trần Đức Linh",
                    Gender = "Nam", Phone = "0905000004", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0004", FullNameCustomer = "Trương Gia Huy",
                    Gender = "Nam", Phone = "0905000005", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0005", FullNameCustomer = "Trương Văn Minh Hiếu",
                    Gender = "Nam", Phone = "0905000006", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0006", FullNameCustomer = "Phạm Thị Thu Hương",
                    Gender = "Nữ", Phone = "0905000007", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0007", FullNameCustomer = "Lê Văn Đức",
                    Gender = "Nam", Phone = "0905000008", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0008", FullNameCustomer = "Phạm Văn Quốc Hiếu",
                    Gender = "Nam", Phone = "0905000009", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0009", FullNameCustomer = "Nguyễn Thị Thùy Trinh",
                    Gender = "Nữ", Phone = "0905000010", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0010", FullNameCustomer = "Nguyễn Phi Hoàng",
                    Gender = "Nam", Phone = "0905000011", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0011", FullNameCustomer = "Lê Trung Kiên",
                    Gender = "Nam", Phone = "0905000012", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0012", FullNameCustomer = "Nguyễn Công Trọng",
                    Gender = "Nam", Phone = "0905000013", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0013", FullNameCustomer = "Lê Tất Chương",
                    Gender = "Nam", Phone = "0905000014", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0014", FullNameCustomer = "Lê Thị Nga",
                    Gender = "Nữ", Phone = "0905000015", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0015", FullNameCustomer = "Lê Thanh Tùng",
                    Gender = "Nam", Phone = "0905000016", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0016", FullNameCustomer = "Nguyễn Thị Mai Hương",
                    Gender = "Nữ", Phone = "0905000017", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0017", FullNameCustomer = "Trần Quốc Thịnh",
                    Gender = "Nam", Phone = "0905000018", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0018", FullNameCustomer = "Nguyễn Ngọc Thịnh",
                    Gender = "Nam", Phone = "0905000019", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0019", FullNameCustomer = "Lê Xuân Thịnh",
                    Gender = "Nam", Phone = "0905000020", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0020", FullNameCustomer = "Trần Khánh Duy",
                    Gender = "Nam", Phone = "0905000021", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0021", FullNameCustomer = "Vũ Thị Yến",
                    Gender = "Nữ", Phone = "0905000022", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0022", FullNameCustomer = "Trần Ngọc Lan Anh",
                    Gender = "Nữ", Phone = "0905000023", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0023", FullNameCustomer = "Lê Thị Hoàng My",
                    Gender = "Nữ", Phone = "0905000024", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0024", FullNameCustomer = "Lê Thị Hoàng Oanh",
                    Gender = "Nữ", Phone = "0905000025", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0025", FullNameCustomer = "Phạm Thị Thùy Trâm",
                    Gender = "Nữ", Phone = "0905000026", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0026", FullNameCustomer = "Hoàng Vĩnh Khánh Linh",
                    Gender = "Nữ", Phone = "0905000027", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0027", FullNameCustomer = "Dương Xuân Kết",
                    Gender = "Nam", Phone = "0905000028", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0028", FullNameCustomer = "Lê Thị Ngọc Diễm",
                    Gender = "Nữ", Phone = "0905000029", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0029", FullNameCustomer = "Hoàng Quốc Bảo",
                    Gender = "Nam", Phone = "0905000030", Address = "Đà Nẵng"},

                new Customer {ID_Customer = "KH0030", FullNameCustomer = "Nguyễn Huy Hoàng",
                    Gender = "Nam", Phone = "0905000031", Address = "Đà Nẵng"},
            });

            context.Languages.AddRange(new Language[]
            {
                new Language {ID_Language = 1, NameLanguage = "Tiếng Việt"},
                new Language {ID_Language = 2, NameLanguage = "Tiếng Anh"},
                new Language {ID_Language = 3, NameLanguage = "Tiếng Nhật"},
                new Language {ID_Language = 4, NameLanguage = "Tiếng Hàn"},
                new Language {ID_Language = 5, NameLanguage = "Tiếng Trung"},
                new Language {ID_Language = 6, NameLanguage = "Song ngữ Việt Anh"},
                new Language {ID_Language = 7, NameLanguage = "Song ngữ Việt Nhật"},
                new Language {ID_Language = 8, NameLanguage = "Song ngữ Việt Hàn"},
                new Language {ID_Language = 9, NameLanguage = "Song ngữ Việt Trung"},
            });

            context.Publishers.AddRange(new Publisher[]
            {
                new Publisher {ID_Publisher = 1, NamePublisher = "Nhà xuất bản Kim Đồng",
                    Email = "cskh_online@nxbkimdong.com.vn", PhoneContact = "(+84) 1900571595"},

                new Publisher {ID_Publisher = 2, NamePublisher = "Nhà xuất bản Trẻ",
                    Email = "hopthubandoc@nxbtre.com.vn", PhoneContact = "(028) 39316289 - 39316211 - 39317849"},

                new Publisher {ID_Publisher = 3, NamePublisher = "Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh",
                    Email = "nstonghop@gmail.com", PhoneContact = "(028) 3825 6804 - 3825 6713 - 3829 6764"},

                new Publisher {ID_Publisher = 4, NamePublisher = "Nhà xuất bản chính trị quốc gia sự thật",
                    Email = "suthat@nxbctqg.vn", PhoneContact = "024 3822 1633"},

                new Publisher {ID_Publisher = 5, NamePublisher = "Nhà xuất bản giáo dục",
                    Email = "nxbgd@gmail.com", PhoneContact = "024 3822 0801"},

                new Publisher {ID_Publisher = 6, NamePublisher = "Nhà xuất bản Hội Nhà văn",
                    Email = "nxbhoinhavan65@gmail.com", PhoneContact = "024.38222135"},

                new Publisher {ID_Publisher = 7, NamePublisher = "Nhà xuất bản Tư pháp",
                    Email = "nxbtp@moj.gov.vn", PhoneContact = "024. 6263 2079"},

                new Publisher {ID_Publisher = 8, NamePublisher = "Nhà xuất bản Thông tin và Truyền thông",
                    Email = "nxb.tttt@mic.gov.vn", PhoneContact = "0243 577 2145"},

                new Publisher {ID_Publisher = 9, NamePublisher = "Nhà xuất bản lao động",
                    Email = "nxblaodong@yahoo.com", PhoneContact = "024 3851 5380"},

                new Publisher {ID_Publisher = 10, NamePublisher = "Nhà xuất bản giao thông vận tải",
                    Email = "nxbgtvt@fpt.vn", PhoneContact = "024 3942 3346"},

                new Publisher {ID_Publisher = 11, NamePublisher = "Nhà xuất bản Đại học Quốc Gia Hà Nội",
                    Email = "nxb@vnu.edu.vn", PhoneContact = "024 3971 4896"},
            });

            context.Genres.AddRange(new Genre[]
            {
                new Genre {ID_Genre = 1, NameGenre = "Chính trị - Pháp luật"},
                new Genre {ID_Genre = 2, NameGenre = "Khoa học công nghệ - Kinh tế"},
                new Genre {ID_Genre = 3, NameGenre = "Văn học nghệ thuật"},
                new Genre {ID_Genre = 4, NameGenre = "Văn hóa xã hội - Lịch sử"},
                new Genre {ID_Genre = 5, NameGenre = "Giáo trình"},
                new Genre {ID_Genre = 6, NameGenre = "Truyện - Tiểu thuyết"},
                new Genre {ID_Genre = 7, NameGenre = "Tâm lý - Tâm linh - Tôn giáo"},
                new Genre {ID_Genre = 8, NameGenre = "Thiếu nhi"},
            });

            context.Books.AddRange(new Book[]
            {
                new Book {ID_Book = "B0000", NameBook = "One Punch Man tập 1", PublishDate = new DateTime(2020, 01, 01), 
                    NameAuthor = "Yusuke Murata", Quantity = 4, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 1.jpg"},

                new Book {ID_Book = "B0001", NameBook = "One Punch Man tập 2", PublishDate = new DateTime(2020, 01, 02),
                    NameAuthor = "Yusuke Murata", Quantity = 2, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 2.jpg"},

                new Book {ID_Book = "B0002", NameBook = "One Punch Man tập 3", PublishDate = new DateTime(2020, 01, 03),
                    NameAuthor = "Yusuke Murata", Quantity = 8, Price = 22000, Unit = "Quyển", ID_Language = 2, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 3.jpg"},

                new Book {ID_Book = "B0003", NameBook = "One Punch Man tập 4", PublishDate = new DateTime(2020, 01, 04),
                    NameAuthor = "Yusuke Murata", Quantity = 10, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 4.jpg"},

                new Book {ID_Book = "B0004", NameBook = "One Punch Man tập 5", PublishDate = new DateTime(2020, 01, 05),
                    NameAuthor = "Yusuke Murata", Quantity = 9, Price = 22000, Unit = "Quyển", ID_Language = 3, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 5.jpg"},

                new Book {ID_Book = "B0005", NameBook = "One Punch Man tập 6", PublishDate = new DateTime(2020, 01, 06),
                    NameAuthor = "Yusuke Murata", Quantity = 15, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 6.jpg"},

                new Book {ID_Book = "B0006", NameBook = "One Punch Man tập 7", PublishDate = new DateTime(2020, 01, 07),
                    NameAuthor = "Yusuke Murata", Quantity = 11, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 7.jpg"},

                new Book {ID_Book = "B0007", NameBook = "One Punch Man tập 8", PublishDate = new DateTime(2020, 01, 08),
                    NameAuthor = "Yusuke Murata", Quantity = 7, Price = 22000, Unit = "Quyển", ID_Language = 2, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 8.jpg"},

                new Book {ID_Book = "B0008", NameBook = "One Punch Man tập 9", PublishDate = new DateTime(2020, 01, 09),
                    NameAuthor = "Yusuke Murata", Quantity = 7, Price = 22000, Unit = "Quyển", ID_Language = 6, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 9.jpg"},

                new Book {ID_Book = "B0009", NameBook = "One Punch Man tập 10", PublishDate = new DateTime(2020, 01, 10),
                    NameAuthor = "Yusuke Murata", Quantity = 9, Price = 22000, Unit = "Quyển", ID_Language = 6, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 10.jpg"},

                new Book {ID_Book = "B0010", NameBook = "One Punch Man tập 11", PublishDate = new DateTime(2020, 01, 11),
                    NameAuthor = "Yusuke Murata", Quantity = 2, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 11.jpg"},

                new Book {ID_Book = "B0011", NameBook = "One Punch Man tập 12", PublishDate = new DateTime(2020, 01, 12),
                    NameAuthor = "Yusuke Murata", Quantity = 4, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 12.jpg"},

                new Book {ID_Book = "B0012", NameBook = "One Punch Man tập 13", PublishDate = new DateTime(2020, 01, 13),
                    NameAuthor = "Yusuke Murata", Quantity = 4, Price = 22000, Unit = "Quyển", ID_Language = 7, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 13.jpg"},

                new Book {ID_Book = "B0013", NameBook = "One Punch Man tập 14", PublishDate = new DateTime(2020, 01, 14),
                    NameAuthor = "Yusuke Murata", Quantity = 6, Price = 22000, Unit = "Quyển", ID_Language = 7, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 14.jpg"},

                new Book {ID_Book = "B0014", NameBook = "One Punch Man tập 15", PublishDate = new DateTime(2020, 01, 15),
                    NameAuthor = "Yusuke Murata", Quantity = 5, Price = 22000, Unit = "Quyển", ID_Language = 2, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 15.jpg"},

                new Book {ID_Book = "B0015", NameBook = "One Punch Man tập 16", PublishDate = new DateTime(2020, 01, 16),
                    NameAuthor = "Yusuke Murata", Quantity = 12, Price = 22000, Unit = "Quyển", ID_Language = 2, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 16.jpg"},

                new Book {ID_Book = "B0016", NameBook = "One Punch Man tập 17", PublishDate = new DateTime(2020, 01, 17),
                    NameAuthor = "Yusuke Murata", Quantity = 16, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 17.jpg"},

                new Book {ID_Book = "B0017", NameBook = "One Punch Man tập 18", PublishDate = new DateTime(2020, 01, 18),
                    NameAuthor = "Yusuke Murata", Quantity = 15, Price = 22000, Unit = "Quyển", ID_Language = 3, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 18.jpg"},

                new Book {ID_Book = "B0018", NameBook = "One Punch Man tập 19", PublishDate = new DateTime(2020, 01, 19),
                    NameAuthor = "Yusuke Murata", Quantity = 10, Price = 22000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 19.jpg"},

                new Book {ID_Book = "B0019", NameBook = "One Punch Man tập 20", PublishDate = new DateTime(2020, 01, 20),
                    NameAuthor = "Yusuke Murata", Quantity = 11, Price = 22000, Unit = "Quyển", ID_Language = 3, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 20.jpg"},

                new Book {ID_Book = "B0020", NameBook = "One Punch Man tập 21", PublishDate = new DateTime(2020, 01, 21),
                    NameAuthor = "Yusuke Murata", Quantity = 10, Price = 22000, Unit = "Quyển", ID_Language = 3, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 21.jpg"},

                new Book {ID_Book = "B0021", NameBook = "One Punch Man tập 22", PublishDate = new DateTime(2020, 01, 22),
                    NameAuthor = "Yusuke Murata", Quantity = 12, Price = 22000, Unit = "Quyển", ID_Language = 7, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 22.jpg"},

                new Book {ID_Book = "B0022", NameBook = "One Punch Man tập 23", PublishDate = new DateTime(2020, 01, 23),
                    NameAuthor = "Yusuke Murata", Quantity = 12, Price = 22000, Unit = "Quyển", ID_Language = 2, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 23.jpg"},

                new Book {ID_Book = "B0023", NameBook = "One Punch Man tập 24", PublishDate = new DateTime(2020, 01, 24),
                    NameAuthor = "Yusuke Murata", Quantity = 16, Price = 22000, Unit = "Quyển", ID_Language = 3, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 24.jpg"},

                new Book {ID_Book = "B0024", NameBook = "One Punch Man tập 25", PublishDate = new DateTime(2020, 01, 25),
                    NameAuthor = "Yusuke Murata", Quantity = 17, Price = 22000, Unit = "Quyển", ID_Language = 6, ID_Publisher = 1, ID_Genre = 6,
                    Image = "Img\\Book\\OPM tap 25.jpg"},

                new Book {ID_Book = "B0025", NameBook = "Giải tích 12", PublishDate = new DateTime(2020, 01, 01),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 15, Price = 8000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-giai-tich-12.jpg"},

                new Book {ID_Book = "B0026", NameBook = "Hình học 12", PublishDate = new DateTime(2020, 01, 2),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 15, Price = 8000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\Hinh-hoc-12-346267-2.jpg"},

                new Book {ID_Book = "B0027", NameBook = "Ngữ Văn 12 tập 1", PublishDate = new DateTime(2020, 01, 3),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 17, Price = 10000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\Sach-giao-khoa-ngu-van-12-tap-1-500x554.jpg"},

                new Book {ID_Book = "B0028", NameBook = "Ngữ Văn 12 tập 2", PublishDate = new DateTime(2020, 01, 4),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 21, Price = 10000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\Sach-giao-khoa-ngu-van-12-tap-2-500x554.jpg"},

                new Book {ID_Book = "B0029", NameBook = "Vật lý 12", PublishDate = new DateTime(2020, 01, 5),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 21, Price = 12000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-vat-ly-12.jpg"},

                new Book {ID_Book = "B0030", NameBook = "Hóa học 12", PublishDate = new DateTime(2020, 01, 6),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 23, Price = 12000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-hoa-hoc-lop-12.jpg"},

                new Book {ID_Book = "B0031", NameBook = "Sinh học 12", PublishDate = new DateTime(2020, 01, 7),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 22, Price = 12000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-sinh-hoc-lop-12.jpg"},

                new Book {ID_Book = "B0032", NameBook = "Địa lí 12", PublishDate = new DateTime(2020, 01, 8),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 25, Price = 12000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-dia-li-lop-12.jpg"},

                new Book {ID_Book = "B0033", NameBook = "Lịch sử 12", PublishDate = new DateTime(2020, 01, 9),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 16, Price = 12000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-lich-su-lop-12.jpg"},

                new Book {ID_Book = "B0034", NameBook = "Tiếng anh 12", PublishDate = new DateTime(2020, 01, 10),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 17, Price = 12000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\sach-giao-khoa-tieng-anh-12.jpg"},

                new Book {ID_Book = "B0035", NameBook = "Tiếng anh thí điểm 12 tập 1", PublishDate = new DateTime(2020, 01, 11),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 7, Price = 30000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\tieng-anh-thi-diem-12-tap-1.jpg"},

                new Book {ID_Book = "B0036", NameBook = "Tiếng anh thí điểm 12 tập 2", PublishDate = new DateTime(2020, 01, 12),
                    NameAuthor = "Bộ giáo dục và đào tạo", Quantity = 10, Price = 30000, Unit = "Quyển", ID_Language = 1, ID_Publisher = 5, ID_Genre = 5,
                    Image = "Img\\Book\\tieng-anh-thi-diem-12-tap-2.jpg"},
            });

            context.Orders.AddRange(new Order[]
            {
                new Order {ID_Order = "HD0000", OrderDate = new DateTime(2022, 05, 28), TotalPrice = 66000,
                    ID_Customer = "KH0001", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0001", OrderDate = new DateTime(2022, 05, 28), TotalPrice = 22000,
                    ID_Customer = "KH0010", ID_Employee = "E0000"},

                new Order {ID_Order = "HD0002", OrderDate = new DateTime(2022, 05, 28), TotalPrice = 22000,
                    ID_Customer = "KH0030", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0003", OrderDate = new DateTime(2022, 05, 29), TotalPrice = 44000,
                    ID_Customer = "KH0029", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0004", OrderDate = new DateTime(2022, 05, 29), TotalPrice = 66000,
                    ID_Customer = "KH0002", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0005", OrderDate = new DateTime(2022, 05, 29), TotalPrice = 44000,
                    ID_Customer = "KH0009", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0006", OrderDate = new DateTime(2022, 05, 29), TotalPrice = 44000,
                    ID_Customer = "KH0004", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0007", OrderDate = new DateTime(2022, 05, 29), TotalPrice = 66000,
                    ID_Customer = "KH0003", ID_Employee = "E0000"},

                new Order {ID_Order = "HD0008", OrderDate = new DateTime(2022, 05, 29), TotalPrice = 44000,
                    ID_Customer = "KH0006", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0009", OrderDate = new DateTime(2022, 05, 30), TotalPrice = 88000,
                    ID_Customer = "KH0000", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0010", OrderDate = new DateTime(2022, 05, 30), TotalPrice = 88000,
                    ID_Customer = "KH0001", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0011", OrderDate = new DateTime(2022, 05, 30), TotalPrice = 110000,
                    ID_Customer = "KH0012", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0012", OrderDate = new DateTime(2022, 05, 30), TotalPrice = 66000,
                    ID_Customer = "KH0009", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0013", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 110000,
                    ID_Customer = "KH0021", ID_Employee = "E0000"},

                new Order {ID_Order = "HD0014", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 16000,
                    ID_Customer = "KH0023", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0015", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 22000,
                    ID_Customer = "KH0008", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0016", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 22000,
                    ID_Customer = "KH0007", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0017", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 22000,
                    ID_Customer = "KH0015", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0018", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 30000,
                    ID_Customer = "KH0004", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0019", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 30000,
                    ID_Customer = "KH0000", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0020", OrderDate = new DateTime(2022, 05, 31), TotalPrice = 16000,
                    ID_Customer = "KH0005", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0021", OrderDate = new DateTime(2022, 06, 01), TotalPrice = 16000,
                    ID_Customer = "KH0007", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0022", OrderDate = new DateTime(2022, 06, 01), TotalPrice = 16000,
                    ID_Customer = "KH0004", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0023", OrderDate = new DateTime(2022, 06, 01), TotalPrice = 22000,
                    ID_Customer = "KH0006", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0024", OrderDate = new DateTime(2022, 06, 01), TotalPrice = 16000,
                    ID_Customer = "KH0009", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0025", OrderDate = new DateTime(2022, 06, 01), TotalPrice = 22000,
                    ID_Customer = "KH0001", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0026", OrderDate = new DateTime(2022, 06, 02), TotalPrice = 60000,
                    ID_Customer = "KH0005", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0027", OrderDate = new DateTime(2022, 06, 02), TotalPrice = 60000,
                    ID_Customer = "KH0000", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0028", OrderDate = new DateTime(2022, 06, 02), TotalPrice = 52000,
                    ID_Customer = "KH0016", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0029", OrderDate = new DateTime(2022, 06, 02), TotalPrice = 24000,
                    ID_Customer = "KH0017", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0030", OrderDate = new DateTime(2022, 06, 03), TotalPrice = 24000,
                    ID_Customer = "KH0018", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0031", OrderDate = new DateTime(2022, 06, 03), TotalPrice = 22000,
                    ID_Customer = "KH0011", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0032", OrderDate = new DateTime(2022, 06, 03), TotalPrice = 20000,
                    ID_Customer = "KH0001", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0033", OrderDate = new DateTime(2022, 06, 03), TotalPrice = 24000,
                    ID_Customer = "KH0024", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0034", OrderDate = new DateTime(2022, 06, 03), TotalPrice = 44000,
                    ID_Customer = "KH0025", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0035", OrderDate = new DateTime(2022, 06, 03), TotalPrice = 20000,
                    ID_Customer = "KH0000", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0036", OrderDate = new DateTime(2022, 06, 04), TotalPrice = 20000,
                    ID_Customer = "KH0008", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0037", OrderDate = new DateTime(2022, 06, 04), TotalPrice = 20000,
                    ID_Customer = "KH0000", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0038", OrderDate = new DateTime(2022, 06, 04), TotalPrice = 22000,
                    ID_Customer = "KH0020", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0039", OrderDate = new DateTime(2022, 06, 04), TotalPrice = 110000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0040", OrderDate = new DateTime(2022, 06, 05), TotalPrice = 20000,
                    ID_Customer = "KH0026", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0041", OrderDate = new DateTime(2022, 06, 05), TotalPrice = 20000,
                    ID_Customer = "KH0027", ID_Employee = "E0000"},

                new Order {ID_Order = "HD0042", OrderDate = new DateTime(2022, 06, 05), TotalPrice = 20000,
                    ID_Customer = "KH0014", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0043", OrderDate = new DateTime(2022, 06, 05), TotalPrice = 52000,
                    ID_Customer = "KH0019", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0044", OrderDate = new DateTime(2022, 06, 05), TotalPrice = 20000,
                    ID_Customer = "KH0028", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0045", OrderDate = new DateTime(2022, 06, 06), TotalPrice = 20000,
                    ID_Customer = "KH0017", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0046", OrderDate = new DateTime(2022, 06, 06), TotalPrice = 20000,
                    ID_Customer = "KH0016", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0047", OrderDate = new DateTime(2022, 06, 06), TotalPrice = 52000,
                    ID_Customer = "KH0000", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0048", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 20000,
                    ID_Customer = "KH0024", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0049", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 20000,
                    ID_Customer = "KH0029", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0050", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 110000,
                    ID_Customer = "KH0022", ID_Employee = "E0000"},

                new Order {ID_Order = "HD0051", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 20000,
                    ID_Customer = "KH0029", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0052", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 110000,
                    ID_Customer = "KH0004", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0053", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 52000,
                    ID_Customer = "KH0008", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0054", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 16000,
                    ID_Customer = "KH0004", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0055", OrderDate = new DateTime(2022, 06, 07), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0056", OrderDate = new DateTime(2022, 06, 08), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0057", OrderDate = new DateTime(2022, 06, 08), TotalPrice = 32000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0058", OrderDate = new DateTime(2022, 06, 08), TotalPrice = 60000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0059", OrderDate = new DateTime(2022, 06, 08), TotalPrice = 42000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0060", OrderDate = new DateTime(2022, 06, 08), TotalPrice = 44000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0061", OrderDate = new DateTime(2022, 06, 09), TotalPrice = 34000,
                    ID_Customer = "KH0021", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0062", OrderDate = new DateTime(2022, 06, 09), TotalPrice = 44000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0063", OrderDate = new DateTime(2022, 06, 09), TotalPrice = 34000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0064", OrderDate = new DateTime(2022, 06, 09), TotalPrice = 38000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0065", OrderDate = new DateTime(2022, 06, 09), TotalPrice = 46000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0066", OrderDate = new DateTime(2022, 06, 10), TotalPrice = 44000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0067", OrderDate = new DateTime(2022, 06, 10), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0068", OrderDate = new DateTime(2022, 06, 10), TotalPrice = 38000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0069", OrderDate = new DateTime(2022, 06, 10), TotalPrice = 42000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0070", OrderDate = new DateTime(2022, 06, 10), TotalPrice = 72000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0071", OrderDate = new DateTime(2022, 06, 11), TotalPrice = 16000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0072", OrderDate = new DateTime(2022, 06, 11), TotalPrice = 52000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0073", OrderDate = new DateTime(2022, 06, 11), TotalPrice = 20000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0074", OrderDate = new DateTime(2022, 06, 11), TotalPrice = 60000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0075", OrderDate = new DateTime(2022, 06, 11), TotalPrice = 66000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0076", OrderDate = new DateTime(2022, 06, 12), TotalPrice = 44000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0077", OrderDate = new DateTime(2022, 06, 12), TotalPrice = 18000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0078", OrderDate = new DateTime(2022, 06, 12), TotalPrice = 20000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0079", OrderDate = new DateTime(2022, 06, 12), TotalPrice = 36000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0080", OrderDate = new DateTime(2022, 06, 12), TotalPrice = 52000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0081", OrderDate = new DateTime(2022, 06, 13), TotalPrice = 34000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0082", OrderDate = new DateTime(2022, 06, 13), TotalPrice = 52000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0083", OrderDate = new DateTime(2022, 06, 13), TotalPrice = 16000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0084", OrderDate = new DateTime(2022, 06, 13), TotalPrice = 20000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0085", OrderDate = new DateTime(2022, 06, 13), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0086", OrderDate = new DateTime(2022, 06, 14), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0087", OrderDate = new DateTime(2022, 06, 14), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0088", OrderDate = new DateTime(2022, 06, 14), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0089", OrderDate = new DateTime(2022, 06, 14), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0090", OrderDate = new DateTime(2022, 06, 14), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0091", OrderDate = new DateTime(2022, 06, 15), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0092", OrderDate = new DateTime(2022, 06, 15), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0093", OrderDate = new DateTime(2022, 06, 15), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0094", OrderDate = new DateTime(2022, 06, 15), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0095", OrderDate = new DateTime(2022, 06, 15), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0096", OrderDate = new DateTime(2022, 06, 16), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0097", OrderDate = new DateTime(2022, 06, 16), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0098", OrderDate = new DateTime(2022, 06, 16), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0099", OrderDate = new DateTime(2022, 06, 16), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0100", OrderDate = new DateTime(2022, 06, 16), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0101", OrderDate = new DateTime(2022, 06, 17), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0102", OrderDate = new DateTime(2022, 06, 17), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0103", OrderDate = new DateTime(2022, 06, 17), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0104", OrderDate = new DateTime(2022, 06, 17), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0105", OrderDate = new DateTime(2022, 06, 17), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0106", OrderDate = new DateTime(2022, 06, 18), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0107", OrderDate = new DateTime(2022, 06, 18), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0108", OrderDate = new DateTime(2022, 06, 18), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0109", OrderDate = new DateTime(2022, 06, 18), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0110", OrderDate = new DateTime(2022, 06, 18), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0111", OrderDate = new DateTime(2022, 06, 19), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0112", OrderDate = new DateTime(2022, 06, 19), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0113", OrderDate = new DateTime(2022, 06, 19), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0114", OrderDate = new DateTime(2022, 06, 19), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0115", OrderDate = new DateTime(2022, 06, 19), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0116", OrderDate = new DateTime(2022, 06, 20), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0117", OrderDate = new DateTime(2022, 06, 20), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0118", OrderDate = new DateTime(2022, 06, 20), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0119", OrderDate = new DateTime(2022, 06, 20), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0120", OrderDate = new DateTime(2022, 06, 20), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0121", OrderDate = new DateTime(2022, 06, 21), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0122", OrderDate = new DateTime(2022, 06, 21), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0123", OrderDate = new DateTime(2022, 06, 21), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0124", OrderDate = new DateTime(2022, 06, 21), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0125", OrderDate = new DateTime(2022, 06, 22), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0126", OrderDate = new DateTime(2022, 06, 22), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0127", OrderDate = new DateTime(2022, 06, 22), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0128", OrderDate = new DateTime(2022, 06, 23), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0129", OrderDate = new DateTime(2022, 06, 23), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0130", OrderDate = new DateTime(2022, 06, 23), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0131", OrderDate = new DateTime(2022, 06, 23), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0132", OrderDate = new DateTime(2022, 06, 23), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0133", OrderDate = new DateTime(2022, 06, 23), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0134", OrderDate = new DateTime(2022, 06, 24), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0135", OrderDate = new DateTime(2022, 06, 24), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0136", OrderDate = new DateTime(2022, 06, 25), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0137", OrderDate = new DateTime(2022, 06, 25), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0138", OrderDate = new DateTime(2022, 06, 25), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0139", OrderDate = new DateTime(2022, 06, 25), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0140", OrderDate = new DateTime(2022, 06, 25), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0141", OrderDate = new DateTime(2022, 06, 26), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0142", OrderDate = new DateTime(2022, 06, 26), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0143", OrderDate = new DateTime(2022, 06, 26), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0144", OrderDate = new DateTime(2022, 06, 26), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0145", OrderDate = new DateTime(2022, 06, 26), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0146", OrderDate = new DateTime(2022, 06, 27), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0147", OrderDate = new DateTime(2022, 06, 27), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0007"},

                new Order {ID_Order = "HD0148", OrderDate = new DateTime(2022, 06, 27), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0149", OrderDate = new DateTime(2022, 06, 27), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0150", OrderDate = new DateTime(2022, 06, 27), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0151", OrderDate = new DateTime(2022, 06, 28), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0152", OrderDate = new DateTime(2022, 06, 28), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0153", OrderDate = new DateTime(2022, 06, 28), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0154", OrderDate = new DateTime(2022, 06, 28), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0155", OrderDate = new DateTime(2022, 06, 28), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0001"},

                new Order {ID_Order = "HD0156", OrderDate = new DateTime(2022, 06, 29), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0157", OrderDate = new DateTime(2022, 06, 29), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0158", OrderDate = new DateTime(2022, 06, 29), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0159", OrderDate = new DateTime(2022, 06, 29), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0160", OrderDate = new DateTime(2022, 06, 29), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0002"},

                new Order {ID_Order = "HD0161", OrderDate = new DateTime(2022, 06, 30), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0162", OrderDate = new DateTime(2022, 06, 30), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0163", OrderDate = new DateTime(2022, 06, 30), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0164", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0165", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0166", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0004"},

                new Order {ID_Order = "HD0167", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0168", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0169", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0170", OrderDate = new DateTime(2022, 07, 01), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0171", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0172", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},

                new Order {ID_Order = "HD0173", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0174", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0003"},

                new Order {ID_Order = "HD0175", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0005"},

                new Order {ID_Order = "HD0176", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0177", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0010"},

                new Order {ID_Order = "HD0178", OrderDate = new DateTime(2022, 07, 02), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0009"},

                new Order {ID_Order = "HD0179", OrderDate = new DateTime(2022, 07, 03), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0006"},

                new Order {ID_Order = "HD0180", OrderDate = new DateTime(2022, 07, 03), TotalPrice = 24000,
                    ID_Customer = "KH0021", ID_Employee = "E0008"},
            });

            context.OrderDetails.AddRange(new OrderDetail[]
            {
                new OrderDetail {ID_Order = "HD0000", ID_Book = "B0002", NameBook = "One Punch Man tập 3",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0000", ID_Book = "B0016", NameBook = "One Punch Man tập 17",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0000", ID_Book = "B0012", NameBook = "One Punch Man tập 13",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0001", ID_Book = "B0000", NameBook = "One Punch Man tập 1",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0002", ID_Book = "B0001", NameBook = "One Punch Man tập 2",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0003", ID_Book = "B0006", NameBook = "One Punch Man tập 7",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0003", ID_Book = "B0001", NameBook = "One Punch Man tập 2",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0004", ID_Book = "B0009", NameBook = "One Punch Man tập 10",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0004", ID_Book = "B0010", NameBook = "One Punch Man tập 11",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0005", ID_Book = "B0016", NameBook = "One Punch Man tập 17",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},

                new OrderDetail {ID_Order = "HD0006", ID_Book = "B0021", NameBook = "One Punch Man tập 22",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0006", ID_Book = "B0006", NameBook = "One Punch Man tập 7",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0007", ID_Book = "B0000", NameBook = "One Punch Man tập 1",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0007", ID_Book = "B0007", NameBook = "One Punch Man tập 8",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0007", ID_Book = "B0010", NameBook = "One Punch Man tập 11",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0008", ID_Book = "B0009", NameBook = "One Punch Man tập 20",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},

                new OrderDetail {ID_Order = "HD0009", ID_Book = "B0004", NameBook = "One Punch Man tập 5",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0009", ID_Book = "B0005", NameBook = "One Punch Man tập 6",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},

                new OrderDetail {ID_Order = "HD0010", ID_Book = "B0014", NameBook = "One Punch Man tập 15",
                    UnitPrice = 22000, Quantity = 3, TotalAmount = 66000},
                new OrderDetail {ID_Order = "HD0010", ID_Book = "B0018", NameBook = "One Punch Man tập 19",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0011", ID_Book = "B0009", NameBook = "One Punch Man tập 10",
                    UnitPrice = 22000, Quantity = 5, TotalAmount = 110000},

                new OrderDetail {ID_Order = "HD0012", ID_Book = "B0006", NameBook = "One Punch Man tập 7",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0012", ID_Book = "B0003", NameBook = "One Punch Man tập 4",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0012", ID_Book = "B0002", NameBook = "One Punch Man tập 3",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0013", ID_Book = "B0001", NameBook = "One Punch Man tập 2",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0013", ID_Book = "B0002", NameBook = "One Punch Man tập 3",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0013", ID_Book = "B0003", NameBook = "One Punch Man tập 4",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0014", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0014", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0015", ID_Book = "B0007", NameBook = "One Punch Man tập 8",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0016", ID_Book = "B0023", NameBook = "One Punch Man tập 24",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0017", ID_Book = "B0024", NameBook = "One Punch Man tập 25",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0018", ID_Book = "B0035", NameBook = "Tiếng anh thí điểm 12 tập 1",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},

                new OrderDetail {ID_Order = "HD0019", ID_Book = "B0001", NameBook = "One Punch Man tập 2",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},

                new OrderDetail {ID_Order = "HD0020", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 2, TotalAmount = 16000},

                new OrderDetail {ID_Order = "HD0021", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 2, TotalAmount = 16000},

                new OrderDetail {ID_Order = "HD0022", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0022", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0023", ID_Book = "B0012", NameBook = "One Punch Man tập 3",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0024", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0024", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0025", ID_Book = "B0015", NameBook = "One Punch Man tập 16",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0026", ID_Book = "B0035", NameBook = "Tiếng anh thí điểm 12 tập 1",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},
                new OrderDetail {ID_Order = "HD0026", ID_Book = "B0036", NameBook = "Tiếng anh thí điểm 12 tập 2",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},

                new OrderDetail {ID_Order = "HD0027", ID_Book = "B0035", NameBook = "Tiếng anh thí điểm 12 tập 1",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},
                new OrderDetail {ID_Order = "HD0027", ID_Book = "B0036", NameBook = "Tiếng anh thí điểm 12 tập 2",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},

                new OrderDetail {ID_Order = "HD0028", ID_Book = "B0035", NameBook = "Tiếng anh thí điểm 12 tập 1",
                    UnitPrice = 30000, Quantity = 1, TotalAmount = 30000},
                new OrderDetail {ID_Order = "HD0028", ID_Book = "B0004", NameBook = "One Punch Man tập 5",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0029", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0029", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 2, TotalAmount = 16000},

                new OrderDetail {ID_Order = "HD0030", ID_Book = "B0030", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 2, TotalAmount = 16000},
                new OrderDetail {ID_Order = "HD0030", ID_Book = "B0001", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0031", ID_Book = "B0013", NameBook = "One Punch Man tập 14",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0032", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0032", ID_Book = "B0029", NameBook = "Vật lý 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0033", ID_Book = "B0030", NameBook = "Hóa học 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},
                new OrderDetail {ID_Order = "HD0033", ID_Book = "B0031", NameBook = "Sinh học 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0034", ID_Book = "B0001", NameBook = "One Punch Man tập 2",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},

                new OrderDetail {ID_Order = "HD0035", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0035", ID_Book = "B0030", NameBook = "Hóa học 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0036", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0036", ID_Book = "B0031", NameBook = "Sinh học 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0037", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0037", ID_Book = "B0032", NameBook = "Địa lý 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0038", ID_Book = "B0016", NameBook = "One Punch Man tập 17",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0039", ID_Book = "B0012", NameBook = "One Punch Man tập 13",
                    UnitPrice = 22000, Quantity = 5, TotalAmount = 110000},

                new OrderDetail {ID_Order = "HD0040", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0040", ID_Book = "B0030", NameBook = "Hóa học 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0041", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0041", ID_Book = "B0033", NameBook = "Lịch sử 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0042", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0042", ID_Book = "B0034", NameBook = "Tiếng anh 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0043", ID_Book = "B0015", NameBook = "One Punch Man tập 16",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0043", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0044", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0044", ID_Book = "B0027", NameBook = "Ngữ văn 12 tập 1",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0045", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0045", ID_Book = "B0028", NameBook = "Ngữ văn 12 tập 2",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0046", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0046", ID_Book = "B0027", NameBook = "Ngữ văn 12 tập 1",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0047", ID_Book = "B0013", NameBook = "One Punch Man tập 14",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0047", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0048", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0048", ID_Book = "B0027", NameBook = "Ngữ văn 12 tập 1",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0049", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0049", ID_Book = "B0028", NameBook = "Ngữ văn 12 tập 2",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0050", ID_Book = "B0000", NameBook = "One Punch Man tập 1",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0050", ID_Book = "B0001", NameBook = "One Punch Man tập 2",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0050", ID_Book = "B0002", NameBook = "One Punch Man tập 3",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0050", ID_Book = "B0003", NameBook = "One Punch Man tập 4",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0050", ID_Book = "B0004", NameBook = "One Punch Man tập 5",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0051", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0051", ID_Book = "B0029", NameBook = "Vật lý 12",
                    UnitPrice = 12000, Quantity = 1, TotalAmount = 12000},

                new OrderDetail {ID_Order = "HD0052", ID_Book = "B0005", NameBook = "One Punch Man tập 6",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0052", ID_Book = "B0006", NameBook = "One Punch Man tập 7",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0052", ID_Book = "B0007", NameBook = "One Punch Man tập 8",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0052", ID_Book = "B0008", NameBook = "One Punch Man tập 9",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},
                new OrderDetail {ID_Order = "HD0052", ID_Book = "B0009", NameBook = "One Punch Man tập 10",
                    UnitPrice = 22000, Quantity = 1, TotalAmount = 22000},

                new OrderDetail {ID_Order = "HD0053", ID_Book = "B0004", NameBook = "One Punch Man tập 5",
                    UnitPrice = 22000, Quantity = 2, TotalAmount = 44000},
                new OrderDetail {ID_Order = "HD0053", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0054", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
                new OrderDetail {ID_Order = "HD0054", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},

                new OrderDetail {ID_Order = "HD0055", ID_Book = "B0025", NameBook = "Giải tích 12",
                    UnitPrice = 8000, Quantity = 2, TotalAmount = 16000},
                new OrderDetail {ID_Order = "HD0055", ID_Book = "B0026", NameBook = "Hình học 12",
                    UnitPrice = 8000, Quantity = 1, TotalAmount = 8000},
            });
        }
    }
}
