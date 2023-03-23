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
        public string cpf { get;  set; }
        public double salario { get;  set; }
        public virtual double getBonificacao()
        {
            return this.salario * 0.10;
        }

        // public static int TotaldeFuncionarios { get;  set; }

        /* public abstract void AumentarSalario();
        //private int _tipo;
        public  double getBonificacao()
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


