////คำนวน BMI ข้อ1

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("---Student 1---");
//            Console.Write("Name: ");
//            string name1 = Console.ReadLine();
//            Console.Write("Input Weight(kg): ");
//            double weight1 = double.Parse(Console.ReadLine());
//            Console.Write("Input Height(cm): ");
//            double height1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("---Student 2---");
//            Console.Write("Name: ");
//            string name2 = Console.ReadLine();
//            Console.Write("Input Weight(kg): ");
//            double weight2 = double.Parse(Console.ReadLine());
//            Console.Write("Input Height(cm): ");
//            double height2 = double.Parse(Console.ReadLine());

//            double heightInMeter1 = height1 / 100;
//            double BMI1 = weight1 / Math.Pow(heightInMeter1, 2);

//            double heightInMeter2 = height2 / 100;
//            double BMI2 = weight2 / Math.Pow(heightInMeter2, 2);

//            Console.WriteLine("\nName: " + name1.ToUpper());
//            Console.WriteLine("BMI: " + Math.Round(BMI1, 2));

//            Console.WriteLine("Name: " + name2.ToUpper());
//            Console.WriteLine("BMI: " + Math.Round(BMI2, 2));

//            double maxBmi = Math.Max(BMI1, BMI2);
//            Console.WriteLine("\n Max BMI : " + Math.Round(maxBmi, 2));
//        }
//    }
//}

//หาค่าเงินเดือน ข้อ 2

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.Write("Your Position : ");
//            string po = Console.ReadLine();

//            Console.Write("\nYour Salary : ");
//            float sa = float.Parse(Console.ReadLine());
//            if (po == "Assistant Developer")
//            {
//                double si = Math.Round(sa * 0.05f + sa);
//                Console.WriteLine("\nYour Salary will be increased to " + si);
//            }
//            else if (po == "IT Support")
//            {
//                double si = Math.Round(sa * 0.07f + sa);
//                Console.WriteLine("\nYour Salary will be increased to " + si);
//            }
//            else if (po == "Senior Developer")
//            {
//                double si = Math.Round(sa * 0.10f + sa);
//                Console.WriteLine("\nYour Salary will be increased to " + si);
//            }
//            else if (po == "Administrator")
//            {
//                double si = Math.Round(sa * 0.8f + sa);
//                Console.WriteLine("\nYour Salary will be increased to " + si);
//            }
//            else
//            {
//                double si = Math.Round(sa * 0.03f + sa);
//                Console.WriteLine("\nYour Salary will be increased to " + si);
//            }
//        }
//    }
//}

//using System.Collections.Generic; ข้อ 3
//using System;

//เพิ่มค่า เเละ ลบค่า

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Principal;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Dictionary<string, double> Student = new Dictionary<string, double>();
//            char Exit;
//            do
//            {
//                Console.WriteLine("-------------------");
//                Console.Write("Number of Student? : ");
//                double NS = double.Parse(Console.ReadLine());
//                Console.WriteLine("-------------------");
//                for (int i = 0; i < NS; i++)
//                {
//                    Console.Write("\nStudent ID : ");
//                    string SID = Console.ReadLine();
//                    Console.Write("Score : ");
//                    double Sc = double.Parse(Console.ReadLine());
//                    Console.WriteLine("Student Id " + SID + " score is " + Sc);

//                    if (Student.TryGetValue(SID, out double oldscore))
//                    {
//                        Student.Remove(SID);
//                        Student.Add(SID, Sc);
//                        Console.WriteLine("Update Score Student " + SID + " from " + oldscore + " to " + Sc);
//                    }
//                    else
//                    {
//                        Student.Add(SID, Sc);
//                    }
//                }
//                Console.Write("\nExit : ");
//                Exit = Convert.ToChar(Console.ReadLine());
//            }
//            while (Exit == 'N');
//            Console.WriteLine("\nResult : " + Student.Values.Count());
//            Console.WriteLine("-------------------");
//            Console.WriteLine("Max Score Student is " + Student.Values.Max());
//            Console.WriteLine("Max Score Student is " + Student.Values.Min());
//        }
//    }
//}


//ข้อ 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant(516, 4);
            Giraffe giraffe = new Giraffe(493, 500);

            double elephantcorrect_age = elephant.correct_age();
            double giraffecorrect_age = giraffe.correct_age();

            float elephantcorrect_height = elephant.correct_height();
            float giraffecorrect_height = giraffe.correct_height();

            Console.WriteLine($"Elephant Age = {elephantcorrect_age} year");
            Console.WriteLine($"Giraffe Age = {giraffecorrect_age} year");

            Console.WriteLine($"Elephant Height = {elephantcorrect_height} m.");
            Console.WriteLine($"Giraffe Height = {giraffecorrect_height} m.");
        }
    }
}