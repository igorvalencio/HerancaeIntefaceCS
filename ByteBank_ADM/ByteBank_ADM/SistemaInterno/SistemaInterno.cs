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
        public bool Logar(diretor Funcionarios, string senha)
        {
            bool UsuarioAutenticado = Funcionarios.autenticar(senha);

            if(UsuarioAutenticado == true)
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
            bool UsuarioAutenticado = Funcionarios.autenticar(senha);

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
