namespace ConferenciaLinhaProducao.Models
{
    // Perfis de usuários do sistema
    public enum UserRole
    {
        Conferente,
        Operador,
        Administrador
    }

    // Status de movimentação de produto em uma rua
    public enum MovementStatus
    {
        Rodando,   // Produto está rodando na linha
        Estocado,  // Produto armazenado no depósito
        Vazio      // Rua sem produto
    }
}
