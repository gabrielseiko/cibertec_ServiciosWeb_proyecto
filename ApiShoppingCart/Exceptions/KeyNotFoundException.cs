using System;
namespace ApiShoppingCart.Exceptions
{
	public class KeyNotFoundException:Exception
	{
		public KeyNotFoundException(string message):base(message)
		{
		}
	}
}

