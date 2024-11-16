using System;
namespace TMS.Domain.Core
{
	public class StandardResponse
	{
		public required string Message { get; set; }
		public required int StatusCode { get; set; }
		public string? Code { get; set; }
	}
}

