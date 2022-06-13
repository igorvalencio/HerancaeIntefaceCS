using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Console.WriteLine("Boas vindas ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

funcionario joao = new funcionario();

joao.nome = "João";
joao.cpf = "321655645";
joao.salario = 2000;

Console.WriteLine("Nome: " + joao.nome);
Console.WriteLine("CPF: " + joao.cpf);
Console.WriteLine("Salário: " + joao.salario);

diretor paula = new diretor();
paula.nome = "Paula";
paula.cpf = "56565665";
paula.salario = 5000;

Console.WriteLine("Bonificação: " + joao.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.registrar(joao);
gerenciador.registrar(paula);
Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());


