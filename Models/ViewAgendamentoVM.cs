namespace ElysiumBeauty.Models
{
    public class ViewAgendamentoVM
    {
        public int Id { get; set; }

        public DateTime DtHoraAgendamento { get; set; }

        public DateOnly DataAtendimento { get; set; }

        public TimeOnly Horario { get; set; }

        public string? TipoServico { get; set; }

        public decimal? Valor { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public string? Telefone { get; set; }
    }
}
