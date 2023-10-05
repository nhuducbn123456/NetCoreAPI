public class Fruit
{
    public int id { get; set; }
    public string? name { get; set; }
    public int soluong { get; set; }

    public void EnterInformation()
    {
        Console.Write("Nhap ma qua: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ten qua: ");
        name = Console.ReadLine();
        Console.Write("Nhap so luong qua: ");
        soluong = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Thong tin qua: ");
        Console.WriteLine("Ma qua: " + id);
        Console.WriteLine("Ten qua: " + name);
        Console.WriteLine("So luong qua: " + soluong);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit Fruit = new Fruit();
            Fruit.EnterInformation();
            Fruit.DisplayInformation();

            Console.ReadLine();
        }
    }
}