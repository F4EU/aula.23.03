using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio._10
{
    class Aluno1 : AbstractAluno
    {
        public override int ObterFalta()
        {
            return 12;
        }

        public override string ObterNome()
        {
            return "Astolfo";
        }

        public override int ObterNota()
        {
            return 69;
        }

        public override string ObterRa()
        {
            return "573";
        }
    }
}
