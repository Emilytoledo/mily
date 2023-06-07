using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_05_correta
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;
            string resposta;


            Console.WriteLine("Bem-vindo ao Detran");
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você tem {idade} anos!");



           
            if(idade>=18)
            
            
            {
              
                Console.WriteLine("Você já pode tirar a CNH");
                


            }

            else
            {

                Console.WriteLine("Você ainda não tem idade...");
               
                Console.WriteLine("Você já tem uma CNH? Digite sim ou não");
                resposta = Console.ReadLine();

                if (resposta == "sim")


                Console.WriteLine("Você deve renovar sua CNH");

                Console.WriteLine(" Você está tirando sua primiera CNH?");




            }

           


                Console.ReadKey();
            Main(null);











        }
    }
}
