using System;
using System.Collections.Generic;
using _2Essential.TasksClass;
using _2Essential.TasksIndexers;
using Essential.Tasks;
using static Essential.Tasks.Program;

namespace Essential
{
    public partial class Program
    {
        private const string PRO_LICENSE = "111";
        private const string EXP_LICENSE = "222";

        public static void Main(string[] args)
        {
            //Address example = new Address();
            //example.Index = 36000;
            //example.Country = "Ukraina";
            //example.City = "Ivano-Frankivsk";
            //example.Street = "Halitska";
            //example.House = 102;
            //example.Apartment = 247;
            //Console.WriteLine($"Index - {example.index} \nCountry - {example.country} \nCity - {example.city} \nStreet - {example.street} \nHouse - {example.house} \nApartment - {example.apartment}");


            //var rectangle = new Rectangle(6.4, 3.8);
            //Console.WriteLine($"Area - {rectangle.Area}, Perimetr - {rectangle.Perimeter}");

            //Book book = new Book()
            //{
            //    Title = new Title(),
            //    Author = new Author(),
            //    Content = new Content()
            //};
            //book.Show();
            //Console.ReadLine();

            //////Figure cube = new Figure("cube");
            //////Console.WriteLine(cube.CalculatePerimeter());
            //////Console.ReadKey();

            //User xxx = new User();
            //xxx.Login = "Parol";
            //xxx.Name = "Marian";
            //xxx.Surname = "Rozumnyi";
            //xxx.Age = 24;
            //Console.WriteLine("Інформація: Login {0}, Name {1}, Surname {2}, Age {3}, Date {4}", xxx.Login, xxx.Name, xxx.Surname, xxx.Age, DateTime.Now);
            //Console.ReadLine();


            //Converter money = new Converter(40.62, 38.61, 45.20);
            //Console.WriteLine("Долар: {0} \nЄвро: {1} \nФунт: {2}", money.GetUsd(), money.GetEur(), money.GetGpb());
            //Console.WriteLine(money.ConvecterGrnInOtherMoney());
            //Console.WriteLine(money.ConvecterOtherMoneyInGrn());
            //Console.ReadKey();


            //Employee info = new Employee();
            //info.Name = "Мар'ян";
            //info.Surname = "Розумний";
            //info.Positions = "Вчитель фізичної культури";
            //info.Salary = 8000;
            //info.Experience = 3;
            //info.Tax = 2000;
            //Console.WriteLine("Ім'я: {0}, Прізвище: {1}, Посада: {2} , Оклад {3} грн, Стаж {4} р., Податок {5} грн", info.Name, info.Surname, info.Positions, info.Salary, info.Experience, info.Tax);
            //Console.ReadLine();


            //Invoice Nds = new Invoice();
            //int sumPaymentAmount;
            //Console.WriteLine($"Повна сума з податком: {sumPaymentAmount = Nds.PaymentAmount * Nds.Quantity} грн.");
            //Console.WriteLine($"Сума оплати без податку: {sumPaymentAmount = (Nds.PaymentAmount * Nds.Quantity - (Nds.PaymentAmount * Nds.Quantity / 5))} грн.");


            //string valuePrinter1 = "Printer1";
            //string valuePrinter2 = "Printer2";

            //Printer printer = new Printer();
            //printer.Print(valuePrinter1);

            //PrinterRed printerRed = new PrinterRed();
            //printerRed.Print(valuePrinter2);

            //Console.ReadLine();


            //ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new ExcelentPupil());
            //cRoom.InfoRead();
            //cRoom.InfoRelax();
            //cRoom.InfoStudy();
            //cRoom.InfoWrite();

            //Console.ReadKey();


            //Vehicle car = new Vehicle();
            //car.Price = 50000;
            //car.Coordinate(40000, 30000);
            //Console.WriteLine("Ціна машини {0}:", car.Price.ToString());
            //Console.WriteLine("Координати машини X:{0},Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());
            //Console.ReadLine();



            //Console.WriteLine("Enter license key:");
            //var license = Console.ReadLine();
            //DocumentWorker worker;
            //switch (license)
            //{
            //    case PRO_LICENSE: worker = new ProDocumentWorker(); break;
            //    case EXP_LICENSE: worker = new ExpertDocumentWorker(); break;
            //    default: worker = new DocumentWorker(); break;
            //}
            //while (true)
            //{
            //    Console.WriteLine("Enter Command (o/e/s/q): ");
            //    switch (Console.ReadLine())
            //    {
            //        case "o": worker.OpenDocument(); break;
            //        case "e": worker.EditDocument(); break;
            //        case "s": worker.SaveDocument(); break;
            //        case "q": return;
            //    }
            //}


            //AbstractHandler XML = new XMLHandler();
            //XML.Open();
            //XML.Create();
            //XML.Chenge();
            //XML.Save();
            //AbstractHandler TXT = new TXTHandler();
            //TXT.Open();
            //TXT.Create();
            //TXT.Chenge();
            //TXT.Save();
            //AbstractHandler DOC = new DOCHandler();
            //DOC.Open();
            //DOC.Create();
            //DOC.Chenge();
            //DOC.Save();
            //Console.ReadLine();


            //IPlayable playable = new BaseClassPlayable();
            //playable.Play();
            //playable.Pause();
            //playable.Stop();
            //IRecodable recodable = new BaseClassRecodable();
            //recodable.Record();
            //recodable.Pause();
            //recodable.Stop();
            //Console.ReadLine();


            //BaseClassIndexer my = new BaseClassIndexer();
            //my.MaxValueIndexer();
            //my.MinValueIndexer();
            //my.TotalNumberIndexers(); 
            //my.ArithmeticMean();  
            //my.OddValues();      
            //Console.ReadLine();  


            //MyMatrix matrix = new MyMatrix(2, 2);

            //matrix.FeedMatrix();
            //matrix.ShowMatrix();

            //Console.WriteLine(new string('-', 30));
            //Console.WriteLine("Число стовбців - {0}\nЧисло рядків - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            //Console.WriteLine(new string('-', 30));

            //matrix.ChangeMatrix(4, 4);
            //matrix.FeedMatrix();
            //matrix.ShowMatrix();
            //Console.WriteLine(new string('-', 30));
            //Console.WriteLine("Число стовбців - {0}\nЧисло рядків - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            //Console.WriteLine(new string('-', 30));

            //matrix[-9, 9] = 123;
            //matrix[2, 10] = 2;


            //Stock stock = new Stock(3);
            //stock[0] = new Article("Штани", "Адідас", 4300);
            //stock[1] = new Article("Куртка", "Рібок", 5340);
            //stock[2] = new Article("Кофта", "Найк", 3040);
            //Article test = stock.FindProduct("Куртка");
            //if (test != null)
            //    Console.WriteLine(test.ToString());
            //Console.WriteLine();
            //Article[] tests = stock.SortByCost();
            //for (int i = 0; i < tests.Length; i++)
            //{
            //    Console.WriteLine(tests[i].ToString());
            //}
            //Console.WriteLine();
            //Console.WriteLine(stock[0] + stock[1]);
            //Console.ReadKey();

            //Console.WriteLine("Enter the first number");
            //Calculator.a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //Calculator.b = Convert.ToInt32(Console.ReadLine());
            //Calculator.Addition();
            //Calculator.Subtraction();
            //Calculator.Multiplication();
            //Calculator.Division();


            PrinterYellow yellow = new PrinterYellow();
            PrinterRed red = new PrinterRed();
            PrinterGreen green = new PrinterGreen();


            var printers = new List<Printer>();
            printers.Add(yellow);
            //printers.Add(green);
            //printers.Add(red);

            ////string polymorphism = "Polymorphism";
            //foreach (var printer in printers)
            //{
            //    printer.Print("Polymorphism");
            //}
            //Console.ReadLine();
            var black = new PrinterBlack();

            black.Print("PrintBlack");
            //black.SetBackgroundColor();
            Console.WriteLine("NormalPrint");

        }

        public static void UsePrinter(Printer printer)
        {
            printer.Print("no polymorphism");
        }
    }
}