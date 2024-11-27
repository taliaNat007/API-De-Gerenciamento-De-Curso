using System.ComponentModel.DataAnnotations.Schema;

namespace API_Gerenciamento_De_Curso.Models
{
    [Table("Professor")]
    public class Professor
    {
        [Column("id_professor")]
        public int Id_Professor { get; set; }

        [Column("nome_professor")]
        public string? Nome_Professor { get; set; }

        [Column("especialidade_professor")]
        public string? Especialidade_Professor { get; set; }

        [Column("cpf_professor")]
        public string? CPF_Professor { get; set; }

        [Column("rg_professor")]
        public string? RG_Professor { get; set; }

        [Column("email_professor")]
        public string? Email_Professor { get; set; }

        [Column("data_nascimento_professor")]
        public DateOnly Data_Nascimento_Professor { get; set; }

    }
}
