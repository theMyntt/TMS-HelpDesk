using System;
namespace TMS.Domain.Core
{
	public interface IUseCase<I, O> where I : class
    {
		Task<O> Run(I input);
	}
}

