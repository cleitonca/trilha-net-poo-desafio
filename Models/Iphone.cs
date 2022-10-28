namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - Feito
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - Feito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}