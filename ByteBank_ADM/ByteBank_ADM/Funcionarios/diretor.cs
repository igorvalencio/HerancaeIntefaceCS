using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class diretor:funcionario
    {
        public override double getBonificacao()
        {
            return salario + base.getBonificacao();
        }
        public diretor(string cpf): base(cpf)
        {
            Console.WriteLine("");
        }
    }
}
    

