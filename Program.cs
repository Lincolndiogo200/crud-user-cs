using crud_user.models;

namespace crud_user {
    class Program {
        static List<UserModel> usuarios = new List<UserModel>();

        static void Listar()
        {
            if (usuarios.Count <= 0)
            {
                Console.WriteLine("Lista sem usuários cadastros.");
                return;
            }
        
            foreach (UserModel u in usuarios)
            {
                Console.WriteLine($"ID - {u.Id}\n Nome: {u.Nome}\n Idade: {u.Idade}\n Gênero: {u.Genero}");
            }
        }

        static void Cadastrar()
        {
            UserModel pessoa = new UserModel("", int.MinValue, '-');
            Console.WriteLine(" -- Cadastro de usuário -- ");
            Console.WriteLine("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
            {
                Console.WriteLine("Nome inválido. Cadastro cancelado!");
                return;
            }


            Console.WriteLine("Digite a idade: ");
            if (!int.TryParse(Console.ReadLine(), out int idade) || idade < 0)
            {
                Console.WriteLine("Idade inválida. Cadastro cancelado.");
                return;
            }
            pessoa.Idade = idade;

            Console.WriteLine("Digite o Gênero:   ex: Masculino - 'M' ou Feminino - 'F'");
            if (!char.TryParse(Console.ReadLine(), out char genero) || (genero != 'M' && genero != 'F'))
            {
                Console.WriteLine("Gênero inválido. Cadastro cancelado.");
                return;
            }
            pessoa.Genero = genero;

            usuarios.Add(pessoa);

            Console.WriteLine($"Usuário Criado com sucesso!\n ID - {pessoa.Id}\n Nome: {pessoa.Nome}\n Idade: {pessoa.Idade}\n {(pessoa.Genero == 'M' ? "Masculino" : "Feminino")}");
           
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1) Listar usuários");
                Console.WriteLine("2) Cadastrar usuário");
                Console.WriteLine("3) Atualizar usuário");
                Console.WriteLine("4) Deletar usuário");
                Console.WriteLine("5) Encerrar Programa");
                Console.Write("\nDigite uma opção: ");
                int opcao = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Listar();
                        break;
                    case 2:
                        Cadastrar();
                        break;
                    case 3:
                        // Atualizar();
                        break;
                    case 4:
                        // Deletar();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }
    }
}