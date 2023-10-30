using System;
namespace ApiBook.Exceptions
{
	public class KeyNotFoundException:Exception
	{
		public KeyNotFoundException(string message):base(message)
		{
		}
	}
}

