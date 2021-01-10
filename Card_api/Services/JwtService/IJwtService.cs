using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casino_api.Services.JwtService
{
	interface IJwtService
	{
		Task<string> NewSession(string id, string secret);
	}
}
