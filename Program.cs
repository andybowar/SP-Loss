using System;

namespace SP_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            SPLossCalc calc = new SPLossCalc();

            Console.WriteLine("What is the largest diameter duct being run?");
            var diameter = Console.ReadLine();

            Console.WriteLine("How many feet of rigid duct will be run?");
            var rigidLength = Console.ReadLine();

            Console.WriteLine("How many feet of flexible duct will be run?");
            var flexLength = Console.ReadLine();

            Console.WriteLine("How many 45 degree angle joints will there be?");
            var num45 = Console.ReadLine();

            Console.WriteLine("How many 90 degree angle joints will there be?");
            var num90 = Console.ReadLine();

            Console.WriteLine("Your total SP loss is: \n");
            Console.WriteLine(calc.SpLossFormula(diameter, 
                Convert.ToDouble(rigidLength),
                Convert.ToDouble(flexLength), 
                Convert.ToInt32(num45), 
                Convert.ToInt32(num90)));

            Console.ReadLine();
        }
    }
}
