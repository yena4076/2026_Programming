namespace _020_ClassStudent
{
    internal class Program
    {
        class Student
        {
            string name, major;
            int age;

            public Student(string name, int age, string major)
            {
                this.name = name;
                this.major = major;
                this.age = age;
            }

            public void DisplayInfo()
            {
                //Console.WriteLine("이름: {0}\n나이: {1}\n전공: {2}", this.name, this.age, this.major);
                Console.WriteLine($"이름: {name}\n나이: {age}\n전공: {major}");
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("김예나", 21, "의료IT공학과");
            s.DisplayInfo();
        }
    }
}
