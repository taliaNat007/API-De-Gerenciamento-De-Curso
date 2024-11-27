using System.ComponentModel.DataAnnotations.Schema;

namespace API_Gerenciamento_De_Curso.Models
{
    [Table("Materia")]
    public class Materia
    {
        [Column("id_materia")]
        public int Id_Materia { get; set; }

        [Column("nome_materia")]
        public string? Nome_Materia { get; set; }

    }
}
