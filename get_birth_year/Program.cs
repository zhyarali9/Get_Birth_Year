using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_birth_year
{
    class Program
    {
        public static int GetCurrentYear()
        {
            int CurrentYear = DateTime.Now.Year;
            return CurrentYear;
        }

        public static int get_year_of_birth(int age,int year)
        {
            return (year - age);
        }

        public static void border()
        {
            Console.WriteLine("==============================");
        }

      

        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            int year_birth=get_year_of_birth(age, GetCurrentYear());

            border();
            Console.WriteLine($"\n your name is : {name}\n your age is : {age}\n and your birth year is : {year_birth}\n");
            border();


        }
    }
}
