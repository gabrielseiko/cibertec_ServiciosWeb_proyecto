using System;
namespace ApiShoppingCart.Exceptions
{
	public class UnauthorizedException:Exception
	{
		public UnauthorizedException(string message):base(message)
		{
		}
	}
}

