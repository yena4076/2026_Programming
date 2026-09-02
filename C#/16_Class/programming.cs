namespace _018_Class
{
    internal class Program
    {
        class Data
        {
            // 데이터(필드, 속성 = 변수)
            private int year, month, day;

            // 동작(메소드 = 함수), 세터(setter), 게터(getter)
            public void SetYear(int year)
            {
                this.year = year;
            }

            public int GetYear() 
            { 
                return this.year;
            }
        }
        static void Main(string[] args)
        {
            Data birthday = new Data();
            // birthday.year = 2006; 이거아님
            birthday.SetYear(2006);

            // Console.WriteLine("나는 {0}년생입니다.", birthday.year); 이거아님
            Console.WriteLine("나는 {0}년생입니다.", birthday.GetYear());
        }
    }
}
