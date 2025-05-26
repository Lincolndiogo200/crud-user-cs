namespace crud_user.models
{
    public class UserModel
    {
        private static int idAtual = 1  ;
        public string? Nome { get; set; }
        public int Id { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }

        public UserModel(string nome, int idade, char genero)
        {
            Id = idAtual++;
            Nome = nome;
            Idade = idade;
            Genero = genero;
        }
        
    }
}