using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class auxiliar : Funcionarios
    {
        public auxiliar(string cpf) : base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            salario *= 0.5;
        }
        public override double getBonificacao()
        {
            return salario * 0.25;
        }
    }
}
