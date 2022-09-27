namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string imei, string memoria) : base(numero, imei, memoria)
        {
        }

        // implementado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando ");
        }
    }
}