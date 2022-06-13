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

        public void registrar (funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.getBonificacao();
        }
        public void registrar (diretor diretor)
        {
            this.TotalBonificacao += diretor.getBonificacao();
        }



        public double getBonificacao()
        {
            return  this.TotalBonificacao;
        }
    }
}
