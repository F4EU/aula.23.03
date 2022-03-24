using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio._07
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Por favor informe sua data de aniversario");
            string dtAniversario = Console.ReadLine();

            DateTime.TryParse(dtAniversario, out DateTime dataAniversarioFormatada);

            int idade = DateTime.Today.Year - dataAniversarioFormatada.Year;

            Console.WriteLine($"idade: {idade}");


            if (idade <= 19)
            {
                Console.WriteLine($"jovem");

            }

            else if (idade <= 59) 
            {
                Console.WriteLine($"adulto");

            } 

            else
                    {
                        Console.WriteLine($"idoso");
                    }

                    Console.ReadLine();
                }
            }
        } 
