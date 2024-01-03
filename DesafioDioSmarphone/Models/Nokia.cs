namespace DesafioDioSmarphone.Models
{
    public class Nokia : Celular
    {
        public override void FazerChamada(string numero)
        {
            Console.WriteLine($"Chamada do celular {Marca} ({Modelo}) para o número {numero}.");
        }

        public override void EnviarMensagem(string numero, string mensagem)
        {
            Console.WriteLine($"Enviando mensagem do celular {Marca} ({Modelo}) para o número {numero}: {mensagem}");
        }

    }
}
