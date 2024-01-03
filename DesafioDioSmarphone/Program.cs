using DesafioDioSmarphone.Models;
using System;

class Program
{
    static void Main()
    {
        Celular celularIphone = new Iphone { Marca = "Apple", Modelo = "iPhone 12" };
        Celular celularNokia = new Nokia { Marca = "Nokia", Modelo = "3310" };

        celularIphone.FazerChamada("123456789");
        celularIphone.EnviarMensagem("987654321", "Olá, estou falando de um Iphone?");

        celularNokia.FazerChamada("555-1234");
        celularNokia.EnviarMensagem("555-5678", "Olá, estou falando de um Nokia");

        Console.ReadKey();
    }
}
