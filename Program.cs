using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {

            Primeiro p = new Primeiro();
            p.nome1 = "Apólo"; 
            p.idade = "5 meses";
            p.peso = "16kg";
            
            Console.WriteLine("O nome do gordo é: " + p.nome1);
            Console.WriteLine("A idade do Apólo é: " + p.idade);
            Console.WriteLine("O peso do bundiones é: " + p.peso);


        
        }
    }
}



        
        
            
        
