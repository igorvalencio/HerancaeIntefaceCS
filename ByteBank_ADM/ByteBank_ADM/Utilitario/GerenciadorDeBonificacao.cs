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
        
        private double TotalBonificacao;

        public void registrar(Funcionarios Funcionarios)
        {
            this.TotalBonificacao += Funcionarios.getBonificacao();
        }
        public double getBonificacao()
        {
            return this.TotalBonificacao;
        }
       

    }
}





