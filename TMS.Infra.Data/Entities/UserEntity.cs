
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Infra.Data.Entities
{
	[Table("TBL_USUARIOS")]
	public class UserEntity
	{
		[Key]
		[Column("ID_USUARIO")]
		public required Guid Id { get; set; }

		[Column("TX_NOME")]
		public required string Name { get; set; }

        [Column("TX_EMAIL")]
		public required string Email { get; set; }

        [Column("TX_SENHA")]
		public required string Password { get; set; }

        [Column("TX_REGISTRO")]
        public required DateTime CreatedAt { get; set; }

        [Column("TX_ATUALIZACAO")]
        public DateTime? UpdatedAt { get; set; }
	}
}

