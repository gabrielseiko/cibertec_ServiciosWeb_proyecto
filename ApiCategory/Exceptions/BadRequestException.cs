using System;
namespace ApiCategory.Exceptions
{
	public class BadRequestException:Exception
	{
		public BadRequestException(string message):base(message)
		{
		}
	}
}

