using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace prashant_proj
{
    internal class Student__detail
    {
        public int roll_no;
       public  string name;
        public double marks;

     public void GetDetails()
        {
            Console.Write(" \n  student details : ");
            Console.Write("\n enter the roll no ");
            roll_no = Convert.ToInt32(Console.ReadLine());

            Console.Write(" enter the name  ");
            name = Console.ReadLine();

            Console.Write(" enter the marks  ");
            marks = Convert.ToDouble(Console.ReadLine()); 

        }
        public void Grade_marks()

        {

            if (marks < 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 65)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 45)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade E");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("name: " + name);
            Console.WriteLine("roll Number: " + roll_no);
            Console.WriteLine("Marks: " + marks);
            Grade_marks();

           
        }
        

    }
}
