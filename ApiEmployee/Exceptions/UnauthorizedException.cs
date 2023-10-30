using System;
namespace ApiEmployee.Exceptions
{
	public class UnauthorizedException:Exception
	{
		public UnauthorizedException(string message):base(message)
		{
		}
	}
}

