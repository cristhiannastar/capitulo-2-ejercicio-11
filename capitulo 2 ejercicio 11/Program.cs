namespace ejercicio11
{
    public class program
    {
        public void Main()
        {
            double pago, metrosp, la, lb, lc, precioc, totprec;
            Console.WriteLine("DIGITE EL LADO ANCHO DE LA ALBERCA");
            la = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el lado largo de la alberca");
            lb = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el lado de la alberca");
            lc = double.Parse(Console.ReadLine());

            Console.WriteLine("digite el precio del agua para llenar la alberca por metro cubico");
            precioc = double.Parse(Console.ReadLine());

            metrosp = la *
                lb * lc;
            totprec = metrosp * precioc;

            Console.WriteLine($"la cantidad de metros cubicos sera {metrosp} cm3");
            Console.WriteLine($"la cantidad de metros cubicos sera {totprec} cm3");
        }
    }
}