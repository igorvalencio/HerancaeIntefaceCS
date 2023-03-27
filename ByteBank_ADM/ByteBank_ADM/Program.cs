using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.ParceiroComercial;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;


#region
//diretor paula = new diretor("832321151", 5000);
//paula.nome = "Paula";
//Console.WriteLine(paula.getBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.registrar(joao);
//gerenciador.registrar(paula);

//Console.WriteLine("Total de bonificação: " + gerenciador.TotalBonificacao);
//Console.WriteLine("Total de funcionarios: " + Funcionario.TotaldeFuncionarios);

//joao.AumentarSalario();
//paula.AumentarSalario();
//Console.WriteLine("Novo salário Pedro: " + joao.salario);
//Console.WriteLine("Novo salário Paula: " + paula.salario);

//funcionario andre = new diretor("5552612", 10000);
//andre.nome = "André";
//Console.WriteLine("Salário André: " + andre.salario);
//Console.WriteLine("Total de funcionarios: " + funcionario.TotaldeFuncionarios);

//Console.WriteLine("Bonificação João: " + joao.getBonificacao());
//Console.WriteLine("Bonificação Paula: " + paula.getBonificacao());
//Console.WriteLine("Bonificação André: " + andre.getBonificacao());

//gerenciador.registrar(joao);
//gerenciador.registrar(paula);
//gerenciador.registrar(andre);

//andre.AumentarSalario();
//Console.WriteLine("Novo salário do João: " + joao.salario);
//Console.WriteLine("Novo salário da Paula: " + paula.salario);
//Console.WriteLine("Novo salário do André: " + andre.salario);

////Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());



//void UsarSistema()
//{
//    SistemaInterno sistemaInterno = new SistemaInterno();

//    diretor roberta = new diretor("258881950-36");
//    roberta.nome = "Roberta";
//    roberta.senha = "123";

//    GerenteDeContas Ursula = new GerenteDeContas("2587451-852");
//    Ursula.nome = "Ursula";
//    Ursula.senha = "321";

//    sistemaInterno.Logar(roberta, "123");
//    sistemaInterno.Logar(Ursula, "321");



//Console.ReadKey();
#endregion

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    designer designer1 = new designer("0021548");
    designer1.nome = "designer1";

    diretor diretor1 = new diretor("0021333");
    diretor1.nome = "diretor1";

    auxiliar auxiliar1 = new auxiliar("0332221");
    auxiliar1.nome = "auxiliar1";

    GerenteDeContas gerente1 = new GerenteDeContas("02321654");
    gerente1.nome = "gerente1";

    gerenciador.registrar(gerente1);
    gerenciador.registrar(diretor1);
    gerenciador.registrar(auxiliar1);
    gerenciador.registrar(designer1);

    Console.WriteLine("Total de bonificação: " + gerenciador.TotalBonificacao);




}
