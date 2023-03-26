using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        
        public string nome { get; set; }
        public string cpf { get;  private set; }
        public double salario { get;  set; }
        public virtual double getBonificacao()
        {
            return this.salario * 0.10;
        }

         public static int TotaldeFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            this.cpf = cpf;
            TotaldeFuncionarios++;
        }
        public void AumentarSalario()
        {
            this.salario = this.salario + (this.salario * 0.1);
        }
        
        /*public  double getBonificacao()
        {
                return this.salario * 0.10;   
        }
        public string senha { get; set; }
        
        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        } */



    }
}   


