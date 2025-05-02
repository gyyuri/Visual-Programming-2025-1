using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_1__Student
{
    internal class Students
    {
        private string name, major;
        public int age;

        //생성자
        public Students(string name, int age, string major)
        {
            this.name = name;
            this.age = age;
            this.major = major;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"이름: {name}\n나이: {age}\n전공: {major}");
        }
    }
}
