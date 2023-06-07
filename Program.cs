using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            string sobrenome; 
            int idade;
            
            
            
            
            
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();

            Console.WriteLine($"Digite o seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Seja bem-vinda {nome} {sobrenome}");

            Console.WriteLine("Digite sua idade");
            idade= Int32.Parse(Console.ReadLine() );
            
            Console.WriteLine($"O Sr(a).{sobrenome} {idade} anos");
            Console.WriteLine($"Daqui 5 anos você terá{idade + 5} anos!"); 

            Console.WriteLine($"Você nasceu no ano de {2023-idade}");
          
            
            
            
            
            
            
            
            
            
            
            Console.ReadKey();





        }

        void Revisao()
        {
            float Lanche = 8.00f;
            float salsicha = 1.50f;
            float Hamburguer = 2.00f;
            float requeijão = 1.50f;
            float bacon = 2.00f;
            float X_tudo = Hamburguer + bacon + salsicha + Lanche;
            float Cachorro_Quente_cremoso = 2 * salsicha + requeijão + Lanche;
            float A_Moda_da_Casa = salsicha + Hamburguer + requeijão + Lanche;
            float combo = X_tudo + Cachorro_Quente_cremoso + A_Moda_da_Casa;

            Console.WriteLine("Cardápio do Conradito lanxes");
            Console.WriteLine("Valores:");
            Console.WriteLine("X-Tudo: hamburguer,bacon e salsicha - R$" + X_tudo);
            Console.WriteLine("Cachorro-quente cremoso:2 salsichas e requeijão - R$" + Cachorro_Quente_cremoso);
            Console.WriteLine("A moda da casa:salsicha,hamburguer,requeijão e bacon-R$" + A_Moda_da_Casa);


            Console.WriteLine("COMBO: X-Tudo+ Cachorro-Quente cremoso+ A moda da casa- R$" + combo);


            Console.ReadKey();

        }





    }
}
