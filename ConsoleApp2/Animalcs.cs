//ข้อ 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animalcs
    {
        private double age;     //มีค่าเป็นเดือน
        private float height;  //มีค่าเป็นเมตร
        public double Age { get { return age; } set { age = value; } }
        public float Height { get { return height; } set { height = value; } }

        public virtual float correct_height()
        {
            return height / 100;
        }
        public virtual double correct_age()
        {
            return age / 12;
        }
    }
}