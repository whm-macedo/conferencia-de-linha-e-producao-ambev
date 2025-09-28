namespace ConferenciaLinhaProducao.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public UserRole Papel { get; set; }
    }
}
