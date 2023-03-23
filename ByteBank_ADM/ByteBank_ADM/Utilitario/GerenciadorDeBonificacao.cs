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

        public void registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.getBonificacao();
        }
        


    }
}





