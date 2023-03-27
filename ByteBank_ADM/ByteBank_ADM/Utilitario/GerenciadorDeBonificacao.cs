using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        
        public double TotalBonificacao { get; private set; }
        
        public void registrar ( diretor diretor)
        {
            this.TotalBonificacao += diretor.getBonificacao();
        }
        public void registrar(designer designer)
        {
            this.TotalBonificacao += designer.getBonificacao();
        }
         public void registrar(GerenteDeContas gerente)
         {
            this.TotalBonificacao += gerente.getBonificacao();
         }

        public void registrar (auxiliar auxiliar)
        {
            this.TotalBonificacao += auxiliar.getBonificacao();

        }


    }
}





