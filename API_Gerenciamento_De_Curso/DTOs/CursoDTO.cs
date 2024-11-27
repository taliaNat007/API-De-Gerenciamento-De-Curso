using System.ComponentModel.DataAnnotations;

namespace API_Gerenciamento_De_Curso.DTOs
{
    public class CursoDTO
    {

        [Required]
        [MinLength(5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres")]
        public string Nome_Curso { get; set; }

        [Required]
        public int Carga_Horaria_Curso { get; set; }

        [Required]
        public int Preco_Curso { get; set; }








        [Required]
        [Length(14, 14, ErrorMessage = "O cpf deve ter no mínimo 14 caracteres")]
        public string Descricao_Curso { get; set; }


        
    }
}
