using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone(numero: "11999999999", modelo: "iPhone 14", imei: "11 111111 111111 1", memoria: 256);
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "11111111111", modelo: "N85", imei: "55 555555 555555 5", memoria: 64);
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
        }
    }
}
