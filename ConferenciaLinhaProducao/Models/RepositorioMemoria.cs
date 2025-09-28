using System.Collections.Generic;

namespace ConferenciaLinhaProducao.Models
{
    public static class RepositorioMemoria
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public static List<Produto> Produtos { get; set; } = new List<Produto>();

        // Método para inicializar alguns dados de teste
        public static void Inicializar()
        {
            Usuarios.Add(new Usuario { Id = 1, Nome = "João Conferente", Login = "joao", Senha = "123", Papel = UserRole.Conferente });
            Usuarios.Add(new Usuario { Id = 2, Nome = "Maria Operadora", Login = "maria", Senha = "123", Papel = UserRole.Operador });

            Produtos.Add(new Produto { Id = 1, Nome = "Antarctica 473ml Multipack", Codigo = "ANT473", Fornecedor = "Antarctica", NotaFiscal = "NF123", QuantidadePaletes = 10, Rua = "IN01", LinhaProducao = "L511", Status = MovementStatus.Rodando });
            Produtos.Add(new Produto { Id = 2, Nome = "Spaten 350ml", Codigo = "SPA350", Fornecedor = "Spaten", NotaFiscal = "NF124", QuantidadePaletes = 8, Rua = "IN02", LinhaProducao = "L512", Status = MovementStatus.Rodando });
        }
    }
}
