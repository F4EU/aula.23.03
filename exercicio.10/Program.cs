using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio._10
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirDadosAluno(new Aluno1());
            ImprimirDadosAluno(new Aluno2());

            Console.ReadLine();
        }
        static void ImprimirDadosAluno(AbstractAluno aluno)
        {
            Console.WriteLine(aluno.ImprimirDados());
        }
    }
}