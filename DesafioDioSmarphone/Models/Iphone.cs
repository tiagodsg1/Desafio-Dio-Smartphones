namespace DesafioDioSmarphone.Models
{
    public class Iphone : Celular
    {
        public override void FazerChamada(string numero)
        {
            Console.WriteLine($"Chamada do iPhone {Modelo} para o número {numero}.");
        }

        public override void EnviarMensagem(string numero, string mensagem)
        {
            Console.WriteLine($"Enviando iMessage do iPhone {Modelo} para o número {numero}: {mensagem}");
        }
    }
}
