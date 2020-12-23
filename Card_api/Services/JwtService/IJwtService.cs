using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_api.Services.JwtService
{
	interface IJwtService
	{
		Task<string> NewSession();
		
	}
}
