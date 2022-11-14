using System;
namespace APIMSLancamentos.Model.Response
{
	public class APIResponse
	{
		public string Message { get; set; }
		public bool Success { get; set; }
		public object? Data { get; set; }
	}
}

