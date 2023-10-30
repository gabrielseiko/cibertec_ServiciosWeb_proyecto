using System;
namespace ApiEmployee.Exceptions
{
	public class NotFoundException:Exception
	{
		public NotFoundException(string message):base(message)
		{
		}
	}
}

