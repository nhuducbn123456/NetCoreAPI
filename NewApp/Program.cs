using NewApp.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        Person ps2 = new Person();
        ps2.InputInfo();


    }
    class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public void InputInfo()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten sinh vien: ");
    
        }
    }
}