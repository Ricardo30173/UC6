namespace EstacionamentoConsole.Models
{
    public class ClienteBase
    {

        public string Cpf { get; set; } = null!;
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public string? Telefone { get; set; }
    }
}