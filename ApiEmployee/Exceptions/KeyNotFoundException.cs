using System;
namespace ApiEmployee.Exceptions
{
	public class KeyNotFoundException:Exception
	{
		public KeyNotFoundException(string message):base(message)
		{
		}
	}
}

