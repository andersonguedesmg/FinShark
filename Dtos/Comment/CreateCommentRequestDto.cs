using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinShark.Dtos.Comment
{
    public class CreateCommentRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "O título não pode ter menos de 5 caracteres")]
        [MaxLength(280, ErrorMessage = "O título não pode ter mais de 280 caracteres ")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "O comentário não pode ter menos de 5 caracteres")]
        [MaxLength(280, ErrorMessage = "O comentário não pode ter mais de 280 caracteres ")]
        public string Content { get; set; } = string.Empty;
    }
}
