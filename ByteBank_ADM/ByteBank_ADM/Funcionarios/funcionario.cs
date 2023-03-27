using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        
        public string nome { get; set; }
        public string cpf { get;  private set; }
        public double salario { get;  protected set; }
        public abstract double getBonificacao();
        public abstract void AumentarSalario();

        public static int TotaldeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.salario = salario;
            this.cpf = cpf;
            TotaldeFuncionarios++;
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


