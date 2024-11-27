using System.ComponentModel.DataAnnotations.Schema;

namespace API_Gerenciamento_De_Curso.Models
{
    [Table("Curso")]
    public class Curso
    {
        [Column("id_curso")]
        public int Id_Curso { get; set; }

        [Column("nome_curso")]
        public string? Nome_Curso { get; set; }

        [Column("descricao_curso")]
        public string? Descricao_Curso { get; set; }

        [Column("carga_horaria_curso")]
        public int Carga_Horaria_Curso { get; set; }

        [Column("preco_curso")]
        public decimal Preco_Curso { get; set; }

    }

}
