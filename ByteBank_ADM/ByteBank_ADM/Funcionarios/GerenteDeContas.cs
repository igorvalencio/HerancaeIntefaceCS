using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            salario *= 1.05;
        }
        public override double getBonificacao()
        {
            return salario * 0.25;
        }

        public string senha { get; set; }
        public bool Autenticar ( string senha)
        {
            return this.senha == senha;
        }
    }
}
