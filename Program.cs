//Perguntar e coletar o nome, sobrenome, idade e cor favorita do usuário, exibindo as respostas no final
string nome;
string sobrenome;
int idade;
string corFavorita;

Console.WriteLine("Olá, tudo bem? Seja bem vindo! Vamos fazer um breve cadastro na nossa loja!");
Console.WriteLine("Para iniciar, por favor, digite qual é o seu nome?");
nome = Console.ReadLine();
Console.WriteLine("E qual é o seu sobrenome?");
sobrenome = Console.ReadLine();
Console.WriteLine("Olá " + (nome) + " " + (sobrenome) + ", digite agora sua idade somente com números");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Estamos quase terminando. Por favor, agora digite sua cor favorita!");
corFavorita = Console.ReadLine();
Console.WriteLine("Agora só conferir os dados que preencheu! Muito obrigado!");
Console.WriteLine($"Seu nome completo: {nome} {sobrenome}");
Console.WriteLine("Sua idade é: " + (idade));
Console.WriteLine("Sua cor favorita é: " + (corFavorita));