namespace YalatefYakareem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.titel = "Skarp programmering med c#";
            book1.auther = "Jan Skansholm";
            book1.page = 1000;
            Console.WriteLine("Book titel is : "+ book1.titel);
            Console.WriteLine("Book auther is :"+book1.auther);
            Console.WriteLine("Book page are:" + book1.page);

            Console.WriteLine("---Mohamed Abdu is smart in C#----");
            Book book2 = new Book();
            book2.titel = "Enkelhet metod att förstå programmering";
            book2.auther = "Mohamed Abdu";
            book2.page = 200;
            Console.WriteLine("Book titel is: "+book2.titel);
            Console.WriteLine("Book auther is: "+book2.auther);
            Console.WriteLine("Book page are :"+book2.page);
        }
    }
}