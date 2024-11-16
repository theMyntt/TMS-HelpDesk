using System;
using System.ComponentModel.DataAnnotations.Schema;
using TMS.Domain.Core;

namespace TMS.Domain.Aggregates
{
    public class UserAggregate : AggregateRoot
	{
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public UserAggregate()
		{
		}

        public override object ToJSON()
        {
            return new
            {
                Id = this.Id,
                Name = this.Name,
                Email = this.Email,
                Password = this.Password,
                CreatedAt = this.CreatedAt,
                UpdatedAt = this.UpdatedAt
            };
        }

        protected override void ValidateDomain()
        {
            throw new NotImplementedException();
        }
    }
}

