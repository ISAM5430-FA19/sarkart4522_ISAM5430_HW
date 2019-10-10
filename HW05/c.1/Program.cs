using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first name");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter last name");
            string name2 = Console.ReadLine();
            Student s1 = new Student(name1,name2);
            Console.WriteLine("enter student number");
            int a = int.Parse(Console.ReadLine());
            s1.studentnumber = a;
            Console.WriteLine("enter major ");
            string b = Console.ReadLine();
            s1.major = b;

            Console.WriteLine("enter classification");
            string c = Console.ReadLine();

            s1.Classification = c;

            
            Console.WriteLine("enter GPA");

            float g = float.Parse(Console.ReadLine());
            s1._gpa = g;



            Console.WriteLine("Information about a student :student id : {0}, Major is :{1}, classifiaction is : {2}", s1.studentnumber, s1.major, s1.Classification);




            Console.WriteLine("Full name is {0}", s1.Name);

             //Student s2 = new Student(c , b);
            

            Console.WriteLine("overall GPA is {0}", s1.overall_GPA);


            


        }
    }
}
