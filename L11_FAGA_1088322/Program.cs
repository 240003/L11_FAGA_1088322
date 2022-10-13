using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_FAGA_1088322
{
    class Program
    {
        static void Main(string[] args)
        {
            double libra, dolar, yen, canteurosl, canteurosd, canteurosy, tipocambiol, tipocambiod, tipocambioy;

            Console.WriteLine("Ingrese cantidad de libras");
            libra = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tipo de cambio para libras");
            tipocambiol = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de dolares");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tipo de cambio para dolares");
            tipocambiod = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de yenes");
            yen = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tipo de cambio para yenes");
            tipocambioy = double.Parse(Console.ReadLine());

            canteurosl = libra * tipocambiol;
            canteurosd = dolar * tipocambiod;
            canteurosy = yen * tipocambioy;


            Console.WriteLine("El tipo de cambio en euros es: {0}", canteurosl);
            Console.ReadLine();
            Console.WriteLine("El tipo de cambio en euros es: {0}", canteurosd);
            Console.ReadLine();
            Console.WriteLine("El tipo de cambio en euros es: {0}", canteurosy);
            Console.ReadLine();
            Console.ReadKey();
        }

    }
}