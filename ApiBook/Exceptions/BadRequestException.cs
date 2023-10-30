using System;
namespace ApiBook.Exceptions
{
	public class BadRequestException:Exception
	{
		public BadRequestException(string message):base(message)
		{
		}
	}
}

