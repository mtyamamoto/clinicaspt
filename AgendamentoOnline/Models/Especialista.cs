namespace AgendamentoOnline.Models
{
    public class Especialista
    {
        public int EspecialistaId { get; set; }
        public string EspecialistaNome { get; set; }

        public string CRM { get; set; }

        public int EspecialidadeId { get; set; }

        public Especialidade Especialidade { get; set; }
    }
}
