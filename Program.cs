using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Testando Nokia ===");
        Smartphone nokia = new Nokia("12345", "Nokia Tijolão", "111111111", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\n=== Testando iPhone ===");
        Smartphone iphone = new Iphone("67890", "iPhone 14", "222222222", 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
    }
}
