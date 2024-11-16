using System;
namespace TMS.Domain.Core
{
	public abstract class AggregateRoot
	{
		public abstract object ToJSON();
		protected abstract void ValidateDomain();
	}
}

