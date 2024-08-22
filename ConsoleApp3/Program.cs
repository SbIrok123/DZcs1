using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CW
            /*
            //string name = "alex";
            //int age = 25;
            //double money = 250.50;
            ////Console.WriteLine("Name : {0}, Age : {1}, Money : {2}",name,age,money);
            //Console.WriteLine($"Name : {name }, Age : {age}, Money : {money}");
            //money = Double.Parse(Console.ReadLine());
            //Console.WriteLine(money);
            //Console.WriteLine("enter age - ");
            //bool success = int.TryParse(Console.ReadLine(),out age);
            //if (success)
            //{
            //    Console.WriteLine($"age : {age}");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //}
            //Console.WriteLine(5%3);
            //int x=0,y=0;
            //Console.WriteLine("enter x - ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter y - ");
            //y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Plus :{x+y}");
            //Console.WriteLine($"Minus :{x-y}");
            //Console.WriteLine($"Multiply :{x*y}");
            //Console.WriteLine($"Devide :{x/y}");
            //Console.WriteLine($"Mode :{x%y}");
            //Console.ReadLine();
            */

            //HW

            //18.Завдання про суму вкладу: Створіть змінні initialDeposit(початковий вклад), annualInterestRate(річна відсоткова ставка) та years(термін вкладу) та обчисліть кінцеву суму вкладу з урахуванням відсотків.

            //double initialDeposit = 1000,annualInterestRate=10;
            //int years = 5;
            //for(int i = 0; i < years; i++)
            //{
            //    initialDeposit += (initialDeposit / 100) * annualInterestRate;
            //    Console.WriteLine($"Year {i+1} : {initialDeposit}");
            //}
            //Console.WriteLine($"After {years} years, final deposit will be {initialDeposit}$");

            //19.Завдання про порівняння знижок: Створіть змінні discount1 та discount2 та порівняйте, яка зі знижок дає велику суму економії.

            //int discount1 = 40,discount2= 60;
            //Console.WriteLine(discount1>discount2? "Discount 1 is more better!": "Discount 2 is more better!");

            //20.Завдання про витрати на бензин: Створіть змінні fuelPrice(ціна за літр бензину), fuelConsumed(кількість літрів палива) та обчисліть загальні витрати на бензин.

            //double fuelPrice = 30;
            //int fuelConsumed = 4;
            //Console.WriteLine($"For {fuelConsumed}l fuel (price for 1lt : {fuelPrice}$), Customer will pay -> {fuelPrice*fuelConsumed}$");

            //21.Завдання про довжину кола: Створіть змінну radius(радіус кола) та обчисліть довжину кола.

            //double radius = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Length of circle : {(2* Math.PI * radius):F2}"); //:F2 после 2 числа после точки оно перестает выводиться в cw

            //22.Завдання про зарплату з бонусами: Створіть змінні baseSalary(базова зарплата) та bonus(сума бонусу) та обчисліть загальну зарплату з урахуванням бонусу.

            //int baseSalary = 12000,bonus = 2000;
            //Console.WriteLine($"total : {baseSalary+bonus}");

            //23.Завдання про площу прямокутника: Створіть змінні length(довжина) та width(ширина) прямокутника та обчисліть його площу.

            //int length = 10, width = 3;
            //Console.WriteLine($"S = {length*width}");

            //24.Завдання про витрати на місяць: Створіть змінні monthlyIncome(щомісячний дохід) та expenses(щомісячні витрати) і обчисліть залишок після обліку витрат.

            //int monthlyIncome = 40000,expenses = 39500;
            //Console.WriteLine($"zalushok : {monthlyIncome - expenses}");

            //25.Завдання про середній бал: Створіть змінні score1, score2, score3, score4 та score5 та обчисліть середній бал за ними.

            //double score1=4, score2=3,score3=3,score4=5,score5=5;
            //Console.WriteLine("avg : {0}",(score1+score2+score3+score4+score5)/5);

            //26.Завдання про суму чисел: Створіть змінні number1, number2 та number3 та обчисліть їх суму.

            //int number1=1, number2=1,number3=1;
            //Console.WriteLine(number1+number2+number3);

            //27.Завдання про відсоткову ставку: Створіть змінні початковогооб'єму (початкова сума), finalAmount (кінцева сума) і роки (кількість років) і обчисліть річну процентну ставку.

            //int firstSum = 1000,lastSum=1100;
            //Console.WriteLine("total percent : {0}",(lastSum-firstSum)/(firstSum/100));

            //28.Завдання про площу кола: Створіть змінну radius(радіус кола) та обчисліть його площу.

            //double radius = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Length of circle : {Math.PI * Math.Pow(radius,2):F2}"); 

            //29.Завдання про кількість сторінок: Створіть змінні totalPages(загальна кількість сторінок) та pagesRead(кількість прочитаних сторінок) та визначте, скільки сторінок залишилося прочитати.

            //int totalPages = 340,pagesRead = 40;
            //Console.WriteLine("Need to read : {0}", totalPages - pagesRead);

            //30.Завдання про ціну квитків: Створіть змінні adultTickets(кількість квитків для дорослих) та childTickets(кількість квитків для дітей) та обчисліть загальну вартість квитків на захід.

            //double priceAdult = 200, priceChild = 100;
            //int adultTickets = 3,childTickets =2;
            //Console.WriteLine("Total money : {0}",(adultTickets*priceAdult)+(childTickets*priceChild));

            //31.Завдання про витрати на навчання: Створіть змінні tuitionFee(вартість навчання), booksCost(вартість підручників) та livingExpenses(витрати на проживання) і обчисліть загальні витрати на навчання.

            //int tuitionFee = 500, booksCost = 400, livingExpenses = 5000000;
            //Console.WriteLine("Total : {0} UAH",tuitionFee+booksCost+livingExpenses);

            //32.Завдання про кількість слів: Створіть змінну текст(текстовий рядок) та обчисліть кількість слів у тексті.

            //int i=0;
            //string word = "Hello";
            //while(i < word.Length) 
            //{
            //    i++;
            //}
            //Console.WriteLine("Total letters : {0}",i);

            //33.Завдання про місткість сховища: Створіть змінні totalCapacity(загальна місткість сховища) і usedCapacity(використовується місткість) і визначте, скільки вільного місця залишилося.

            //double totalCapacity = 100, usedCapacity = 39.9 ;
            //Console.WriteLine($"We have space : {totalCapacity - usedCapacity}");

            //34.Завдання про зарплату після утримання: Створіть змінні grossSalary(грос - зарплата) та taxRate(ставка податку) та обчисліть чисту зарплату після утримань.

            //int grossSalary = 5000;
            //double taxrate = 4.5;
            //Console.WriteLine(grossSalary - (grossSalary / 100 * taxrate));
            
            Console.ReadKey();

        }
    }
}

