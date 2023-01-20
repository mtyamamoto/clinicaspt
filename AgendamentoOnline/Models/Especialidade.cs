namespace AgendamentoOnline.Models
{
    public class Especialidade
    {
        public int EspecialidadeId { get; set; }
        public string EspecialidadeNome { get; set; }
        public ICollection<Especialista> Especialistas { get; set; }
    }
}
