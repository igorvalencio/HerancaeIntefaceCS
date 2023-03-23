using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM
{
     internal class AutenticacaoHelper
    {
        public bool CompararSenhas (string SenhaVerdadeira, string SenhaTentativa)
        {
            return SenhaVerdadeira == SenhaTentativa;
        }
    }
}
