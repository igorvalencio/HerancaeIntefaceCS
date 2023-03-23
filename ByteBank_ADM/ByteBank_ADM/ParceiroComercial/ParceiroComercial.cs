using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ParceiroComercial
{
    public abstract  class ParceiroComercial: IAutenticavel
    {
        private AutenticacaoHelper _autenticacaohelper = new AutenticacaoHelper();
        public string senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaohelper.CompararSenhas(senha, senha);
        }
    }
}
