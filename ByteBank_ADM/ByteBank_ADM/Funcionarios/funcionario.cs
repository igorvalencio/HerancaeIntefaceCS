using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionarios
    {

        public Funcionarios(string cpf, double salario)
        {
            cpf = cpf;
            salario = salario;
            TotaldeFuncionarios++;
        }

        public string nome { get;  set; }
        public string cpf { get;  set; }
        public double salario { get;   protected set; }
        public static int TotaldeFuncionarios { get; private set; }
        public abstract void AumentarSalario();
        public abstract double getBonificacao();

      
}   }   


