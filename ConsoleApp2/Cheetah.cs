//ข้อ 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Elephant : Animalcs
    {
        public Elephant(double age, float height)
        {
            Age = age;
            Height = height;
        }
        public override float correct_height()
        {
            return Height / 1;
        }
    }
    internal class Giraffe : Animalcs
    {
        public Giraffe(double age, float height)
        {
            Age = age;
            Height = height;
        }
    }
}
