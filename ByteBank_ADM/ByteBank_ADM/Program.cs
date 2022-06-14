using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Console.WriteLine("Boas vindas ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

funcionario joao = new funcionario();
funcionario paula = new diretor();
funcionario andre = new diretor();

joao.nome = "João";
joao.cpf = "321655645";
joao.salario = 2000;

paula.nome = "Paula";
paula.cpf = "56565665";
paula.salario = 5000;

andre.nome = "André";
andre.cpf = "5552612";
andre.salario = 7000;

Console.WriteLine("Bonificação João: " + joao.getBonificacao());
Console.WriteLine("Bonificação Paula: " + paula.getBonificacao());
Console.WriteLine("Bonificação André: " + andre.getBonificacao());

gerenciador.registrar(joao);
gerenciador.registrar(paula);
gerenciador.registrar(andre);

Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());


