using System;

namespace proyecto
{
    class contador_sodas
    {
        static void Main(string[] args)
        {
            double Tcanc = 0;
            double C1 = 0.65, C2 = 0.60, C3 = 0.60, C4 = 0.60, C5 = 0.50, C6 = 0.60, C7 = 0.65, C8 = 0.50;
            int bebida, Cbebida;
            int cocacola, Mnaranja, Muva, pepsi, agua, petit, delvalle, coca0;
            cocacola = 29;
            Mnaranja = 15;
            Muva = 10;
            pepsi = 12;
            agua = 17;
            petit = 35;
            delvalle = 20;
            coca0 = 23;
            Console.WriteLine("     Bebida           Precio         disponibles");
            Console.WriteLine("1- Coca Cola          $0.65              {0}", cocacola);
            Console.WriteLine("2- Mirinda naranja    $0.60              {0}", Mnaranja);
            Console.WriteLine("3- Mirinda uva        $0.60              {0}", Muva);
            Console.WriteLine("4- Pepsi              $0.60              {0}", pepsi);
            Console.WriteLine("5- Petit              $0.50              {0}", petit);
            Console.WriteLine("6- Del valle          $0.60              {0}", delvalle);
            Console.WriteLine("7- Coca Cola cero     $0.65              {0}", coca0);
            Console.WriteLine("8- agua               $0.50              {0}", agua);
            Console.WriteLine();
           
    }
}
