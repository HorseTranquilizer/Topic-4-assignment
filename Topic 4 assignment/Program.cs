using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace Topic_4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            int age;
            Console.WriteLine("what is your age");
            age = Convert.ToInt32(Console.ReadLine());
            int salary;
            Console.WriteLine(age + " huh? wow you sure are ancient history, how much do you make a year grandpa?");
            int age5;
            age5 = age + 5;
            Console.WriteLine("In 5 years youll be " + age5);
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(salary + " wow I hope thats per hour and not per year!");
            string last_name;
            Console.WriteLine("what is your last name?");
            last_name = Console.ReadLine();
            string grade;
            Console.WriteLine("what grade are you in?");
            grade = Console.ReadLine();
            int student_id;
            Console.WriteLine("what is your student id?");
            student_id = Convert.ToInt32(Console.ReadLine());
            string loginname;
            Console.WriteLine("what is your login name?");
            loginname = Console.ReadLine();
            int gradeav;
            Console.WriteLine("what is your  grade average");
            gradeav = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(     name);
            Console.WriteLine(     last_name);
            Console.WriteLine(     grade);
            Console.WriteLine(     student_id);
            Console.WriteLine(     loginname);
            Console.WriteLine(     gradeav);
            Console.WriteLine();
            Console.WriteLine();
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Dumb calculator: write 3 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            int ans;
            ans = num1 + num2 + num3;
            Console.WriteLine(ans / 2);
            Console.WriteLine();
            Console.WriteLine();
            string item1;
            Console.WriteLine("Give me the name of 1 item at a store");
            item1 = Console.ReadLine();
            int price1;
            Console.WriteLine("how much does it cost");
            price1 = Convert.ToInt32(Console.ReadLine());
            string item2;
            Console.WriteLine("give me the name of another item");
            item2 = Console.ReadLine();
            int price2;
            Console.WriteLine("how much does it cost?");
            price2 = Convert.ToInt32(Console.ReadLine());
            double totalprice1;
            totalprice1 = ((price1 + price2)*0.20);
            double finalprice;
            finalprice = totalprice1 * 0.13;

            
            


        }
    }
}
