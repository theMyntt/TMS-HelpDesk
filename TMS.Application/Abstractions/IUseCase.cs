using System;
namespace TMS.Application.Abstractions
{
	public interface IUseCase<I, O> where I : class
    {
		Task<O> Run(I input);
	}
}

