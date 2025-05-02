namespace _026_Student_class
{
    internal class Program
    {
        class Student
        {
            private string name, major;
            private int age;

            public Student()
            {
                name = "";
                major = "";
                age = 0;
            }

            public Student(string name, int age, string major)
            {
                this.name = name;
                this.major = major;
                this.age = age;
            }

            public void DisplayInfo()
            {
                Console.WriteLine("이름: {0}, 나이: {1}, 전공: {2}", name, age, major);
            }
        }

        static void Main(string[] args)
        {
           Student student = new Student("홍길동", 20, "의료it공학");
            student.DisplayInfo();
           
        }
    }
}
