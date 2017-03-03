using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2PrepEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists ex
            /*
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }
            Console.WriteLine("\nClass Roster");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i] + "(" + grades[i] + ")");
            }

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
            */

            //escape character "\"
            //string myString = "My \"so-called\" life";

            //new line "\n"
            //string myString = "What if I need a\nnew line?";

            //literal depiction "@"
            //string myString = @"Got to your C\ drive";

            //insertions
            //string myString = String.Format("{0} = {1}", "First", "Second");

            //currency
            //string myString = string.Format("{0:C}", 123.45);

            //large number
            //string myString = string.Format("{0:N}", 1234567890);

            //percentage
            //string myString = string.Format("{0:P}", .546);

            //custom format---format right to left if too many numbers
            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            //string myString = " I'm in love with the shape of you  ";

            //shows characters from 6th character and gives the next 14
            //myString = myString.Substring(6,14);

            //upper case
            //myString = myString.ToUpper();

            //replace
            //myString = myString.Replace(" ", "--");

            //remove
            //myString = myString.Remove(6, 14);

            //remove trailing and preceeding with Trim; length  of string using Length; build funcitons on each other
            /*
            myString = String.Format("Length before :{0} -- Length after : {1}",
                myString.Length,
                myString.Trim().Length);
                */

            /*
            String myString = "";
            for (int i = 0; i <100; i++)
            {
                myString += "--" + i.ToString();
            }
            */


            //more efficient concatanation use StringBuilder class
            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i<100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
            */

            //List
            /*
            List<int> numbers = new List<int>(){1,2,3,4,5,};
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Enter a number: ");
                int newNumber = int.Parse(Console.ReadLine());
                numbers[i] = newNumber;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            */

            //Lists amd strings

            List<string> stringList = new List<string>();
            List<string> fiveList = new List<string>();
            foreach (string i in stringList)
            {
                if (i.Length == 5)
                {
                    fiveList.Add(i);
                }
            }
            for (int i = 0; i < fiveList.Count; i++)
            {
                Console.WriteLine(fiveList[i]);
            }
        }
    }
}

