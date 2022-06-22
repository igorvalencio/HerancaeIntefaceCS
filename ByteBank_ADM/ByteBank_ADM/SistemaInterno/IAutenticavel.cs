using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public string senha { get; set; }

        public bool Autenticar(string senha);


    }
}
