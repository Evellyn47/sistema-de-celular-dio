namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("📞 Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("📲 Recebendo ligação...");
        }

        // Método abstrato para ser sobrescrito nas subclasses
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
