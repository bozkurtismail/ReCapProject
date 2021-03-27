﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool loop = true;

            CarManager      carManager      = new CarManager(new EfCarDal(), new UserValidationManager());
            BrandManager    brandManager    = new BrandManager(new EfBrandDal());
            ColorManager    colorManager    = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager   rentalManager   = new RentalManager(new EfRentalDal());
            UserManager     userManager     = new UserManager(new EfUserDal());
            

            do
            {
                MainPage();
                Console.Write("\n LÜTFEN SEÇİMİNİZİ YAPINIZ : ");
                string _tempString = Console.ReadLine();

                if (_tempString == "")
                {
                    choice = 0;
                }
                else
                {
                    choice = Convert.ToInt32(_tempString);
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        ListToBrands(brandManager);
                        Console.WriteLine();
                        ListToColors(colorManager);
                        Console.WriteLine();
                        AddToCar(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 2:
                        ListToCars(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 3:
                        ListToBrands(brandManager);
                        ListToCarsByBrandId(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 4:
                        ListToColors(colorManager);
                        ListToCarsByColorId(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 5:
                        UpdateToCar(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 6:
                        DeleteToCar(carManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 7:
                        ListToBrands(brandManager);
                        AddToBrand(brandManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 8:
                        ListToBrands(brandManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 9:
                        ListToColors(colorManager);
                        AddToColor(colorManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 10:
                        ListToColors(colorManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 11:
                        AddToUser(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 12:
                        ListToUsers(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 13:
                        UpdateToUser(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 14:
                        DeleteToUser(userManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 15:
                        ListToUsers(userManager);
                        Console.WriteLine();
                        AddToCustomer(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 16:
                        ListToCustomers(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 17:
                        ListToUsers(userManager);
                        Console.WriteLine();
                        ListToCustomers(customerManager);
                        Console.WriteLine();
                        UpdateToCustomer(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 18:
                        ListToCustomers(customerManager);
                        Console.WriteLine();
                        DeleteToCustomer(customerManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 19:
                        ListToCars(carManager);
                        ListToCustomerDetails(customerManager);
                        Console.WriteLine();
                        AddToRental(rentalManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 20:
                        ListToRentalDetails(rentalManager);
                        Console.WriteLine();
                        UpdateToRentalReturnDate(rentalManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 21:
                        ListToRentalDetails(rentalManager);
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                    case 00:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim !!!");
                        Console.Write("\nMenüye dönmek için ENTER tuşuna basınız....");
                        Console.ReadLine();
                        break;
                }
            } while (loop);
        }

        #region ANA SAYFA
        private static void MainPage()
        {
            Console.WriteLine();
            Console.WriteLine(String.Format(@" _________________________________________ ANA SAYFA ___________________________________________________"));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 1 ] - Araç Ekleme", "[ 11] - Kullanıcı Ekleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 2 ] - Araç Listeleme", "[ 12] - Kullanıcı Listeleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 3 ] - Araç Listeleme - <Markasına Göre>", "[ 13] - Kullanıcı Güncelleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 4 ] - Araç Listeleme - <Rengine Göre>", "[ 14] - Kullanıcı Silme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 5 ] - Araç Güncelleme", "[ 15] - Müşteri Ekleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 6 ] - Araç Silme", "[ 16] - Müşteri Listeleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 7 ] - Marka Ekleme", "[ 17] - Müşteri Güncelleme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 8 ] - Marka Listeleme", "[ 18] - Müşteri Silme"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 9 ] - Renk Ekleme", "[ 19] - Araç Kirala"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", " [ 10] - Renk Listeleme", "[ 20] - Araç Kiralama Güncelle"));
            Console.WriteLine(String.Format("| {0,-50}{1,-50} |", "", "[ 21] - Araç Kiralama Listesi"));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "[ 00] - ÇIKIŞ", ""));
            Console.WriteLine(String.Format("| {0,50}{1,-50} |", "", ""));
            Console.WriteLine(String.Format(@"|______________________________________________________________________________________________________|"));
        }
        #endregion

        #region ARAÇ İŞLEMLERİ
        private static void AddToCar(CarManager carManager)
        {
            int _brandId, _colorId;
            decimal _dailyPrice;
            string _description, _modelYear;

            ListToCars(carManager);
            Console.WriteLine();

            

            Console.Write("Renk ID : ");
            _colorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Günlük Fiyat : ");
            _dailyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Model Yılı : ");
            _modelYear = Console.ReadLine();
            Console.Write("Açıklama : ");
            _description = Console.ReadLine();
            Console.WriteLine();           
            
            var result = carManager.Add(new Car
            {
                BrandId     = _brandId,
                ColorId     = _colorId,
                ModelYear   =_modelYear,
                DailyPrice  = _dailyPrice,
                Description = _description
            });
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(result.Message);
            Console.ResetColor();
            Console.WriteLine();
            ListToCars(carManager);
        }
        private static void ListToCars(CarManager carManager)
        {
            var result = carManager.GetCarDetail();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5 }| {1,-30}| {2,-20}| {3,-15}| {4,-15}|", "ID", "CAR NAME", "BRAND NAME", "CAR COLOR", "DAILY PRICE"));
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var car in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5 }| {1,-30}| {2,-20}| {3,-15}| {4,-15}|", car.CarId, car.CarName, car.BrandName, car.ColorName, car.DailyPrice));
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------");
        }
        private static void ListToCarsByBrandId(CarManager carManager)
        {
            Console.Write("Listelemek istediğiniz Marka ID : ");
            int listBrandId = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", "ID", "BRAND ID", "COLOR ID", "MODEL YEAR", "DAILY PRICE", "DESCRIPTION"));
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var car in carManager.GetCarsByBrandId(listBrandId).Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description));
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
        private static void ListToCarsByColorId(CarManager carManager)
        {
            Console.Write("Listelemek istediğiniz Renk ID : ");
            int listColorId = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", "ID", "BRAND ID", "COLOR ID", "MODEL YEAR", "DAILY PRICE", "DESCRIPTION"));
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var car in carManager.GetCarsByColorId(listColorId).Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-10}| {3,-10}| {4,-15}| {5,-30}|", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description));
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }
        private static void UpdateToCar(CarManager carManager)
        {
            int _updateCarId, _brandId, _colorId;
            decimal _dailyPrice;
            string _modelYear, _description;

            ListToCars(carManager);
            Console.WriteLine();

            Console.Write("Güncellemek istediğiniz Kayıt ID : ");
            _updateCarId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marka ID : ");
            _brandId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Renk ID : ");
            _colorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Günlük Fiyat : ");
            _dailyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Model Yılı : ");
            _modelYear = Console.ReadLine();
            Console.Write("Açıklama : ");
            _description = Console.ReadLine();
            Console.WriteLine();

            carManager.Update(new Car 
            {
                CarId       = _updateCarId,
                BrandId     = _brandId,
                ColorId     = _colorId,
                DailyPrice  = _dailyPrice,
                ModelYear   = _modelYear,
                Description = _description
            });

            Console.WriteLine("\n<<< Listenin Son Hali >>>");
            ListToCars(carManager);
        }
        private static void DeleteToCar(CarManager carManager)
        {
            ListToCars(carManager);

            int _deleteId;
            Console.WriteLine();

            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _deleteId = Convert.ToInt32(Console.ReadLine());

            Car deleteCar = new Car {  };

            carManager.Delete(new Car { CarId = _deleteId });
            Console.WriteLine();

            Console.WriteLine("<<< Listenin Son Hali >>>");
            ListToCars(carManager);
        }       
        #endregion

        #region MARKA İŞLEMLERİ
        private static void AddToBrand(BrandManager brandManager)
        {
            string brandName;
            Console.Write("\nEklemek istediğiniz yeni Marka Adı : ");
            brandName = Console.ReadLine();

            var result=brandManager.Add(new Brand {BrandName=brandName});
            Console.WriteLine(result.Message);

        }
        private static void ListToBrands(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", "ID", "MARKA"));
            Console.WriteLine("-------------------------");

            Console.ResetColor();
            foreach (var brands in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", brands.BrandId, brands.BrandName));
            }
            Console.WriteLine("-------------------------");
        }
        #endregion

        #region RENK İŞLEMLERİ
        private static void AddToColor(ColorManager colorManager)
        {
            string colorName;
            Console.Write("\nEklemek istediğiniz yeni Renk Adı : ");
            colorName = Console.ReadLine();

            var result = colorManager.Add(new Color { ColorName=colorName});
            Console.WriteLine(result.Message);
        }
        private static void ListToColors(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", "ID", "RENK"));
            Console.WriteLine("-------------------------");

            Console.ResetColor();
            foreach (var colors in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-15}|", colors.ColorId, colors.ColorName));
            }
            Console.WriteLine("-------------------------");
        }
        #endregion

        #region KULLANICI İŞLEMLERİ
        private static void AddToUser(UserManager userManager)
        {
            string _firstName, _lastName, _email, _password;

            Console.Write("Kullanıcı Adı        : ");
            _firstName = Console.ReadLine();
            Console.Write("Kullanıcı Soyadı     : ");
            _lastName = Console.ReadLine();
            Console.Write("Kullanıcı Email      : ");
            _email = Console.ReadLine();
            Console.Write("Kullanıcı Şifre      : ");
            _password = Console.ReadLine();            

            var result = userManager.Add(new User { FirstName = _firstName, LastName = _lastName, Email = _email, Password = _password });
            Console.WriteLine(result.Message);
        }
        private static void ListToUsers(UserManager userManager)
        {
            var result = userManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-20}| {2,-20}| {3,-25}|", "ID", "AD", "SOYAD", "EMAIL"));
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var user in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-5}| {1,-20}| {2,-20}| {3,-25}|", user.UserId, user.FirstName, user.LastName, user.Email));
            }
            Console.WriteLine("-------------------------------------------------------------------------------");
        }
        private static void UpdateToUser(UserManager userManager)
        {
            string _firstName, _lastName, _email, _password;
            int _updateUserId;

            ListToUsers(userManager);
            Console.WriteLine();

            Console.Write("Güncellenecek UserID : ");
            _updateUserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adı          :");
            _firstName = Console.ReadLine();
            Console.Write("Soyadı       :");
            _lastName = Console.ReadLine();
            Console.Write("Email        :");
            _email = Console.ReadLine();
            Console.Write("Şifre        :");
            _password = Console.ReadLine();

            var result = userManager.Update(new User
            {
                UserId = _updateUserId,
                FirstName = _firstName,
                LastName = _lastName,
                Email = _email,
                Password = _password
            });
            Console.WriteLine(result.Message);
        }
        private static void DeleteToUser(UserManager userManager)
        {
            int _deleteUserId;
            ListToUsers(userManager);
            Console.WriteLine();

            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _deleteUserId = Convert.ToInt32(Console.ReadLine());

            var result = userManager.Delete(new User {UserId=_deleteUserId});
            Console.WriteLine(result.Message);
        }
        #endregion

        #region MÜŞTERİ İŞLEMLERİ
        private static void AddToCustomer(CustomerManager customerManager)
        {
            string _companyName;
            int _userId;
            string _nullUserId;

            Console.Write("Kullanıcı ID : ");
            _nullUserId = Console.ReadLine();

            if (_nullUserId == "" || _nullUserId == null)
            {
                Console.WriteLine("Kullanıcı ID boş geçilemez...");

            }
            else
            {
                _userId = Convert.ToInt32(_nullUserId);
                Console.Write("Şirket Adı   : ");
                _companyName = Console.ReadLine();

                var result = customerManager.Add(new Customer 
                {
                    UserId=_userId,
                    CompanyName=_companyName 
                });
                Console.WriteLine(result.Message);
            }
        }
        private static void ListToCustomers(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-5}| {1,-10}| {2,-44}|", "ID", "USER ID", "COMPANY NAME"));
            Console.WriteLine("------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var customer in result.Data)
            {
                Console.WriteLine("| {0,-5}| {1,-10}| {2,-44}|", customer.CustomerId, customer.UserId, customer.CompanyName);
            }
            Console.WriteLine("------------------------------------------------------------------");
        }        
        private static void UpdateToCustomer(CustomerManager customerManager)
        {
            int _customerId, _userId;
            string _companyName;

            Console.Write("Güncellenecek Kayıt ID   : ");
            _customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni Kullanıcı ID        : ");
            _userId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni Şirket Adı          : ");
            _companyName = Console.ReadLine();

            var result = customerManager.Update(new Customer 
            {
                CustomerId=_customerId,
                UserId=_userId,
                CompanyName=_companyName 
            });
            Console.WriteLine(result.Message);
        }
        private static void DeleteToCustomer(CustomerManager customerManager)
        {
            int _deletedCustomerId;

            Console.Write("Silmek istediğiniz Kayıt ID : ");
            _deletedCustomerId = Convert.ToInt32(Console.ReadLine());

            var result = customerManager.Delete(new Customer 
            {
                CustomerId=_deletedCustomerId 
            });
            Console.WriteLine(result.Message);
        }
        private static void ListToCustomerDetails(CustomerManager customerManager)
        {
            var result = customerManager.GetCustomerDetail();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-15}| {1,-15}| {2,-15}| {3,-40}|", "MÜSTERİ ID", "MÜŞTERİ ADI", "MÜŞTERİ SOYADI", "ŞİRKET ADI"));
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var customer in result.Data)
            {
                Console.WriteLine("| {0,-15}| {1,-15}| {2,-15}| {3,-40}|", customer.CustomerId, customer.UserFirstName, customer.UserLastName, customer.CompanyName);
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
        }
        #endregion

        #region KİRALAMA İŞLEMLERİ
        private static void AddToRental(RentalManager rentalManager)
        {
            string _tempCustomer;
            int _carId, _customerId;
            DateTime _rentDate;
            DateTime? _returnDate;

            Console.Write("Kiralaması yapacak 'Müşteri ID' : ");
            _tempCustomer = Console.ReadLine();
            if (_tempCustomer != null)
            {
                Console.Write("Kiralanacak Araç ID         : ");
                _carId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kiralama Tarihi[aa/gg/yyyy] : ");
                _rentDate = Convert.ToDateTime(Console.ReadLine());
                _returnDate = null;
                _customerId = Convert.ToInt32(_tempCustomer);
                var result = rentalManager.Add(new Rental
                {
                    CarId       = _carId,
                    CustomerId  = _customerId,
                    RentDate    = _rentDate,
                    ReturnDate  = _returnDate
                });
                Console.WriteLine(result.Message);

            }
        }
        private static void UpdateToRentalReturnDate(RentalManager rentalManager)
        {
            int _updateRentalId;
            DateTime _returnDateUpdate;

            Console.Write("Araç iadesi yapılacak 'KIRALAMA ID' : ");
            _updateRentalId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aracın İade Tarihi [aa/gg/yyyy]     : ");
            _returnDateUpdate = Convert.ToDateTime(Console.ReadLine());           

            var result = rentalManager.UpdateReturnDate(new Rental
            {
                RentalId = _updateRentalId,
                ReturnDate = _returnDateUpdate
            });
            Console.WriteLine(result.Message);
        }
        private static void ListToRentalDetails(RentalManager rentalManager)
        {
            var result = rentalManager.GetRentalDetails();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(result.Message);
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,-3}| {1,-20}| {2,-40}| {3,-30}| {4,-15}| {5,-12}| {6,-12}| {7,-23}| {8,-23}|", "ID", "MÜŞTERİ ADI-SOYADI", "ŞİRKET ADI", "ARAÇ", "MARKA", "RENK", "KİRA BEDELİ", "KİRA TARİHİ", "İADE TARİHİ"));
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            Console.ResetColor();
            foreach (var rental in result.Data)
            {
                Console.WriteLine(String.Format("| {0,-3}| {1,-20}| {2,-40}| {3,-30}| {4,-15}| {5,-12}| {6,-12}| {7,-23}| {8,-23}|",
                                                    rental.RentalId, rental.CustomerFirstName + " " + rental.CustomerLastName,
                                                    rental.CustomerCompanyName, rental.CarName, rental.BrandName, rental.ColorName, rental.DailyPrice,
                                                    rental.RentDate.ToShortDateString(), rental.ReturnDate
                                                ));
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
        #endregion
    }
}
