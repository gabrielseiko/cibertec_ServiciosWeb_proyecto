﻿using System;
namespace ApiCustomer.Exceptions
{
	public class NotFoundException:Exception
	{
		public NotFoundException(string message):base(message)
		{
		}
	}
}

