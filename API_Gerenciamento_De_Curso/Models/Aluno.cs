using System.ComponentModel.DataAnnotations.Schema;

namespace API_Gerenciamento_De_Curso.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("id_aluno")]
        public int Id_Aluno { get; set; }

        [Column("nome_aluno")]
        public string? Nome_Aluno { get; set; }

        [Column("cpf_aluno")]
        public string? CPF_Aluno { get; set; }

        [Column("rg_aluno")]
        public string? RG_Aluno { get; set; }

        [Column("email_aluno")]
        public decimal Email_Aluno { get; set; }

        [Column("data_nascimento_aluno")]
        public DateOnly Data_Nascimento_Aluno { get; set; }


    }
}
