using System;

namespace ExercicioMaiorDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;

            System.Console.Write("Digite o primeiro numero: ");
            first = Convert.ToInt32(System.Console.ReadLine()); 

            System.Console.Write("Digite o segundo numero: ");
            second = Convert.ToInt32(System.Console.ReadLine());
            
            if(first > second)
            {
                System.Console.WriteLine($" {first} é maior que {second}!");
            }
            else if(first < second)
            {
                System.Console.WriteLine($" {second} é maior que {first}!");
            }
            else
            {
                System.Console.WriteLine($"{first} e {second} sao iguais!");
            }
        }
    }
}
