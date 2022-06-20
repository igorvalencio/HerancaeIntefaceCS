using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(diretor funcionarios, string senha)
        {
            bool UsuarioAutenticado = Funcionarios.Autenticar(senha);

            if (UsuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
        public bool Logar(GerenteDeContas Funcionarios, string senha)
        {
            bool UsuarioAutenticado = Funcionarios.Autenticar(senha);

            if (UsuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
