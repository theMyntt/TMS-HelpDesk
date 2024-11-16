using System;
namespace TMS.Domain.Core
{
	public interface IMapper<Aggregate, Entity> where Aggregate : AggregateRoot where Entity : class
	{
		Aggregate ToDomain(Entity entity);
		Entity ToPersistance(Aggregate aggregate);
	}
}

