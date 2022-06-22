using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.ParceiroComercial;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

//CalcularBonificacao();
UsarSistema();

//Console.WriteLine("Boas vindas ao ByteBank Administração");

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//funcionario joao = new funcionario("321655645", 2000);
//joao.nome = "João";
//Console.WriteLine("Salário João: " + joao.salario);
//Console.WriteLine("Total de funcionarios: " + funcionario.TotaldeFuncionarios);

//funcionario paula = new diretor("56565665", 5000);
//paula.nome = "Paula";
//Console.WriteLine("Salário Paula: " + paula.salario);
//Console.WriteLine("Total de funcionarios: " + funcionario.TotaldeFuncionarios);0

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



void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    diretor roberta = new diretor("258881950-36");
    roberta.nome = "Roberta";
    roberta.senha = "123";

    GerenteDeContas Ursula = new GerenteDeContas("2587451-852");
    Ursula.nome = "Ursula";
    Ursula.senha = "321";

    //ParceiroComercial joao = new ParceiroComercial();
    //joao.senha = "123";

    //sistemaInterno.Logar(pedro, "123");
    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(Ursula, "123");
    //sistemaInterno.Logar(joao, "123");

    Funcionarios pedro = new designer("258.635.854-45");
    pedro.nome = "Pedro";
    pedro.senha = "123";



}

Console.ReadKey();

