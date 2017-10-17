using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            nome = "Apólo";
            Console.WriteLine("Hello Apólo!");
            Console.WriteLine(nome);

            Double valor = 1.5;
            Double quantidade = 2.5;
            Double resultado = valor * quantidade;
            Console.WriteLine(resultado);

            Boolean maiorQueDez = valor > 10;
            if (maiorQueDez) {
                Console.WriteLine($"{resultado} é maior que dez");
            }else{
                Console.WriteLine($"{resultado} é menor que dez");

            }
        
            String nome1 = "Apólo";
            String idade = "5 meses";
            String peso = "16kg";
        

            Console.WriteLine($"{nome1}, {idade}, {peso}");

        
        }
    }
}



        
        
            
        
