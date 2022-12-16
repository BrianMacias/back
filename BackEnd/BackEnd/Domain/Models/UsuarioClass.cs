using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Domain.Models
{
	public class UsuarioClass
	{
		public int Id { get; set; }
        [Required]
        [Column (TypeName ="varchar(20)")]

        public int NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]

        public int Password { get; set; }

    }
}

