using System;
namespace ApiBook.Exceptions
{
	public class NotFoundException:Exception
	{
		public NotFoundException(string message):base(message)
		{
		}
	}
}

