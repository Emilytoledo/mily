using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_03___atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Emily";
             string idade= "21";
            bool cliente1 = true;
            string nome2 ="Carlos";
            bool cliente2 = false;
            int qnt_cafe = 187;
            int qnt_cafe2 = 5;

            int qnt_total = qnt_cafe + qnt_cafe2;

            int qnt_cafe_restante= 200 - qnt_cafe;
            int qnt_cafe_restante2 = 200 - qnt_cafe2;

            Console.WriteLine("Olá");
            Console.WriteLine("Bem- vindo ao sistema de usuários de Emily");
            Console.WriteLine("Abaixo estão as informações dos usuários cadastrados no nosso sistema");
            Console.WriteLine("\n\n");
            Console.WriteLine("----- Lista de Usuários:");
            Console.WriteLine($" 1-{nome1} {idade} é cliente:{cliente1} ");
            Console.WriteLine($" 1-{nome2} {idade} é cliente:{cliente2} ");
           
            Console.WriteLine("\n\n\n");
            Console.WriteLine("----Quantidade de cafés");
           
            Console.WriteLine($"O cielnte{nome1}já tomou{qnt_cafe} cafés");
            Console.WriteLine($"O cielnte{nome2}já tomou{qnt_cafe2} cafés");

            Console.WriteLine($"A soma {qnt_cafe}+ {qnt_cafe2}");



















            Console.ReadKey();

















        }





    }
}
