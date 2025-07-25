﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
	public class ApiResponse<T>
	{
		public T Data { get; set; }
		public bool Success { get; set; }
		public string Message { get; set; }
	}
}
