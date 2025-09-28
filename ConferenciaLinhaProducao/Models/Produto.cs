namespace ConferenciaLinhaProducao.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Fornecedor { get; set; } = null!;
        public string NotaFiscal { get; set; } = null!;
        public int QuantidadePaletes { get; set; }
        public string Rua { get; set; } = null!;
        public string LinhaProducao { get; set; } = null!; // L511, L512, L514
        public MovementStatus Status { get; set; } = MovementStatus.Rodando;
    }
}
