using ByteBank_ADM.Funcionarios;

Console.WriteLine("Boas vindas ao ByteBank Administração");

funcionario joao = new funcionario();

joao.nome = "João";
joao.cpf = "321655645";
joao.salario = 2000;

Console.WriteLine(joao.getBonificacao());