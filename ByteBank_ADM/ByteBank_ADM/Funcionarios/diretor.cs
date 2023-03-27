using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class diretor : Funcionario
    {
        public diretor(string cpf, double salario) : base(cpf, 5000)
        {
            this.salario = salario;
        }

        public override double getBonificacao()
        {
            return this.salario * 0.50;
        }

        public override void AumentarSalario()
        {
            this.salario *= 1.15;
        }

       




        /* public diretor(string cpf) : base(cpf, 5000)
         {

         }

         public string senha { get; set; }

         public override void AumentarSalario()
         {
             this.salario *= 1.15;
         }

         public bool Autenticar(string senha)
         {
             throw new NotImplementedException();
         }

         public  double getBonificacao()
         {
             return salario * 0.5;
         }*/




    }
}
    

