using System;
namespace ApiCustomer.Exceptions
{
	public class BadRequestException:Exception
	{
		public BadRequestException(string message):base(message)
		{
		}
	}
}

