﻿using System;
namespace ApiCustomer.Exceptions
{
	public class KeyNotFoundException:Exception
	{
		public KeyNotFoundException(string message):base(message)
		{
		}
	}
}

