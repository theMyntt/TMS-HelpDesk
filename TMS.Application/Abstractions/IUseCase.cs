using System;
namespace TMS.Application.Abstractions
{
	public interface IUseCase<I, O> where I : class where O : class
    {
		Task<O> Run(I input);
	}
}

