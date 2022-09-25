using _1_exercise._3_exercise;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_exercise
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public string GetAddress()
        {
            return $" Index: {index};\n Country: {country};\n City: {city};\n Street: {street};\n House: {house};\n Apartment: {apartment};";
        }

    }

    namespace _1_exercise
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Address solution\n");
                Address someAddress = new Address();

                someAddress.Index = 02138;
                someAddress.Country = "Ukraine";
                someAddress.City = "Kyiv";
                someAddress.Street = "Unnamed";
                someAddress.House = 8;
                someAddress.Apartment = 310;

                Console.WriteLine(someAddress.GetAddress());

                Console.ReadKey();
            }
        }
    }
  
    namespace _2_exercise
    {
        class Converter
        {

            public double grn = 1;
            public double usd = 41;
            public double eur = 36;
            public double rub = 0.67;

            public Converter(double usdx, double eurx, double rubx)
            {
                usd = usdx;
                eur = eurx;
                rub = rubx;
            }

            public void Choice()
            {
                Console.Write("How much grn do you have?:");

                double grn = Convert.ToDouble(Console.ReadLine());

                Console.Write("if you want convert grn into usd press - 1\ninto eur prees - 2\ninto rub press - 3\n");

                Console.Write("If you want convert usd into grn press - 4\neur into grn press - 5\nrub into grn- 6\n>>>");

                int pick = Convert.ToInt32(Console.ReadLine());

                switch (pick)
                {

                    case 1:
                        Console.Write($"You have: {Math.Round(grn / 41, 2)} usd\n");
                        return;

                    case 2:
                        Console.Write($"You have: {Math.Round(grn / 36, 2)} eur\n");
                        break;

                    case 3:
                        Console.Write($"You have: {Math.Round(grn * 6.7, 2)} rub\n");
                        break;

                    case 4:
                        Console.Write("How much usd do you have?: ");

                        double usd = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"You have: {Math.Round(usd * 41, 2)} grn"); //At that moment I learned that it is possible to write
                        break;                                    //WriteLine instead of \n like in C++

                    case 5:
                        Console.Write("How much eur do you have?: ");

                        double eur = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"You have: {Math.Round(eur * 36, 2)} grn\n");
                        break;

                    case 6:
                        Console.Write("How much rub do you have?: ");

                        double rub = Convert.ToDouble(Console.ReadLine());

                        Console.Write($"You have: {Math.Round(rub / 6.7, 2)} grn\n\n\n");

                        break;
                    default:

                        Console.WriteLine("Wrong choice -_-");

                        break;

                }
            }
        }
    }
    namespace _2_exercise
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Converter solution\n");

                Converter ezConverter = new Converter(41, 36, 0.67);

                ezConverter.Choice();

                Console.ReadKey();
            }
        }
    }
    namespace _3_exercise
    {
        class Employee
        {
            private string first;
            private string last;
            private string pos;
            private int exp;
            private int okl;
            private int sbir = 20;

            public Employee(string firstName, string lastName)
            {
                first = firstName;
                last = lastName;
            }

            public void Rozrahunok()
            {
                if (pos == "junior" || pos == "Junior" && exp <= 1)
                {
                    okl = 1000;
                }
                else if (pos == "middle" || pos == "Middle" && exp <= 4 && 1 <= exp)
                {
                    okl = 3000;
                }
                else if (pos == "senior" || pos == "Senior" && 4 <= exp)
                {
                    okl = 5000;
                }
                else
                {
                    pos = "trainee";
                    exp = 0;
                    okl = 500;
                }
            }


            public void Write()
            {
                Console.WriteLine($"Name: {first} \nLast Name: {last} \nPosition: {pos} \nExpirience: {exp} years" +
                    $" \nSalary: {okl}$ in nanosek \nTax collection: {sbir}%");
            }
        }
    }
    namespace _3_exercise
    {
        class Program
        {
             static void Main(string[] args)
             {
                  Console.WriteLine("Employee solution\n");

                  Employee denchik = new Employee("Denis", " Danilenko");

                  denchik.Rozrahunok();

                  denchik.Write();

                  Console.ReadKey();
             }
         }
    }
    namespace _4_exercise
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("User solution\n");

                User ezUser = new User();

                ezUser.Vivod();

                Console.ReadKey();
            }
        }
    }
    namespace _4_exercise
    {
        class User
        {
            private string login = "SavchukValeria";
            private string name = "Lera";
            private string surname = "Savchuk";
            private int age = 18;
            private const string date = "25.09.2022";

            public void Vivod()
            {
                Console.WriteLine($"Login: {login};\nName: {name};\nSurname: {surname};\nAge: {age};\nDate: {date};");
            }
        }
    }
    namespace Laboratory_2222
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
   