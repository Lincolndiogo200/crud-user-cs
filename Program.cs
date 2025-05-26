using crud_user.models;

namespace crud_user {
    class Program {
        static List<UserModel> usuarios = new List<UserModel>();

        static void Listar()
        {
            foreach (UserModel u in usuarios)
            {
                Console.WriteLine($"ID - {u.Id}\n Nome: {u.Nome}\n Idade: {u.Idade}\n Gênero: {u.Genero}");
            }
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
                Console.WriteLine("Digite uma opção: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        Listar();
                        break;
                    case 2:
                        Cadastrar();
                        break;
                    case 3:
                        Atualizar();
                        break;
                    case 4:
                        Deletar();
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