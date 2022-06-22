using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, autenticado
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }
        public string senha { get; set; }
        public bool autenticar(string senha)
        {
            return senha == senha;
        }
    }
}
