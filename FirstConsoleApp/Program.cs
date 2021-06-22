using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();

            string varialbleOne = "My first Variable=";
            int variableTwo = 1;
            int variableThree = 5;
            int result = Addition(variableTwo, variableThree);

            Console.WriteLine("Addition:" + result);
            Console.WriteLine("Multiplication in class:" + operation.Multiplication(5, 3));
            Console.WriteLine(varialbleOne + variableTwo);
            Console.WriteLine("Hello World!");
        }
        private static int Addition(int varOne, int varTwo)
        {
            return varOne + varTwo;
        }
    }
}
  
