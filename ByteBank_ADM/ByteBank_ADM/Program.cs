using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

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



void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    designer joao = new designer("654.321.887-95");
    joao.nome = "João";

    auxiliar paula = new auxiliar("521.658.887-82");
    paula.nome = "Paula";

    GerenteDeContas Jonatas = new GerenteDeContas("338.521.478-63");
    Jonatas.nome = "Jonatas";

    diretor Ananias = new diretor("225.145.603-89");
    Ananias.nome = "Ananias";

    Desenvolvedor jailson = new Desenvolvedor("258.146.328-55");
    jailson.nome = "Jailson";

    gerenciador.registrar(joao);
    gerenciador.registrar(paula);
    gerenciador.registrar(Jonatas);
    gerenciador.registrar(Ananias);
    gerenciador.registrar(jailson);

    Console.WriteLine();
}


Console.ReadKey();

