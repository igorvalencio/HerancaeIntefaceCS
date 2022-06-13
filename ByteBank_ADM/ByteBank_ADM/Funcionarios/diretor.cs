using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    internal class diretor
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public double salario { get; set; }
        public double getBonificacao()
        {
            return salario;
        }
    }
}
    

