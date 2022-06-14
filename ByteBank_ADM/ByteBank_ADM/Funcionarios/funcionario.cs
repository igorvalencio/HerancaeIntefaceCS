using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class funcionario
    {

        public string nome { get; set; }
        public string cpf { get;  set; }
        public double salario { get;  set; }
        public virtual double getBonificacao()
        {
            return salario * 0.10;
        }
        public static int TotaldeFuncionarios { get; private set; }

        public funcionario(string cpf, double salario)
        {
            this.salario = salario;
           this.cpf = cpf;
            TotaldeFuncionarios++;
        }
        public virtual void AumentarSalario()
        {
            this.salario *= 1.1;
        }

}    }   


