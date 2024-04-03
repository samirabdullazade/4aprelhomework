using System;
using System.Xml;
using _4aprelhomework.Task1;
using _4aprelhomework.Task2;
using _4aprelhomework.Task3;
using _4aprelhomework.Task4;

namespace _4aprelhomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateArea());
            Square square = new Square();
            Console.WriteLine(square.CalculateArea());
            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.CalculateArea());
            

            SavingsAccount account = new SavingsAccount();
            Console.WriteLine($"İstifadəçi nömrəsi {account.AccountNumber}");
            Console.WriteLine($"Debit karta depozit qoyulduqdan sonrakı məbləğ : {account.Deposit(200)}");
            Console.WriteLine($"Debit kartdan pul çıxarıldıqdan sonrakı məbləğ : {account.Withdraw(100)}");
            Console.WriteLine($"Debit kartda olan yekun məbləğ : {account.CalculateInterest()}");
            CurrentAccount account1 = new CurrentAccount();
            Console.WriteLine($"Kredit karta depozit qoyulduqdan sonrakı məbləğ : {account1.Deposit(300)}");
            Console.WriteLine($"Kredit kartdan pul çıxarıldıqdan sonrakı məbləğ : {account1.Withdraw(500)}");
            Console.WriteLine($"Kredit kartda olan yekun məbləğ : {account1.CalculateInterest()}");
            FullTimeEmployee employee1 = new FullTimeEmployee();
            Console.WriteLine(employee1.Name);
            Console.WriteLine(employee1.EmployeeId);
            Console.WriteLine(employee1.CalculateSalary(8));
            PartTimeEmployee employee2 = new PartTimeEmployee();
            Console.WriteLine(employee2.Name);
            Console.WriteLine(employee2.EmployeeId);
            Console.WriteLine(employee2.CalculateSalary(4));
            Book book = new Book();
            book.AvailableCopies = 10;
            book.CheckOut();
            book.CheckOut();
            book.CheckOut();
            book.Return();
            Console.WriteLine(book.AvailableCopies);
            DVD dVD = new DVD();
            dVD.AvailableCopies = 8;
            dVD.CheckOut();
            dVD.CheckOut();
            dVD.Return();
            Console.WriteLine(dVD.AvailableCopies);
            Maqazine maqazine = new Maqazine();
            dVD.AvailableCopies = 9;
            maqazine.CheckOut();
            maqazine.CheckOut();
            maqazine.CheckOut();
            maqazine.CheckOut();
            maqazine.CheckOut();
            maqazine.CheckOut();
            maqazine.Return();
            Console.WriteLine(maqazine.AvailableCopies);


        }
    }
}
