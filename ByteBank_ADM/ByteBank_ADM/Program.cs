using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Console.WriteLine("Boas vindas ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

funcionario joao = new funcionario("321655645");
joao.nome = "João";
joao.salario = 2000;
Console.WriteLine("Total de funcionarios: " + funcionario.TotaldeFuncionarios);

funcionario paula = new diretor("56565665");
paula.nome = "Paula";
paula.salario = 5000;
Console.WriteLine("Total de funcionarios: " + funcionario.TotaldeFuncionarios);

funcionario andre = new diretor("5552612");
andre.nome = "André";
andre.salario = 7000;
Console.WriteLine("Total de funcionarios: " + funcionario.TotaldeFuncionarios);

Console.WriteLine("Bonificação João: " + joao.getBonificacao());
Console.WriteLine("Bonificação Paula: " + paula.getBonificacao());
Console.WriteLine("Bonificação André: " + andre.getBonificacao());

gerenciador.registrar(joao);
gerenciador.registrar(paula);
gerenciador.registrar(andre);

andre.AumentarSalario();
Console.WriteLine("Novo salário do André: " + andre.salario);

Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());


