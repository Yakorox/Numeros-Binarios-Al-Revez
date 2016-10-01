using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarioAlrevez
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;

            Console.WriteLine("INGRESE EL NUMERO A PROCESAR: ");
            num = Convert.ToInt32(Console.ReadLine());


            Binario bin = new Binario(num);

            bin.calcularReversoBinario();
            bin.GenerarBinarios();
            bin.calcularDecimales();
            bin.Mostrar();
            Console.Read();
        }
    }
}
