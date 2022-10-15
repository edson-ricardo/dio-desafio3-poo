namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }        
        protected string Modelo;
        protected string Imei;
        protected int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // IMPLEMENTADO
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public Smartphone(string numero, string modelo) : this(numero)
        {
        }

        public Smartphone(string numero, string modelo, int memoria) : this(numero, modelo)
        {
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}