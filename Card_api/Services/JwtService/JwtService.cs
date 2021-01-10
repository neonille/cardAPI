using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Text;

namespace Casino_api.Services.JwtService
{
	public class JwtService : IJwtService
	{
		public async Task<string> NewSession(string id, string secret)
		{
			Guid guid = new Guid();
			var payload = new Dictionary<string, object>()
			{
				{ "id", id},
				{ "exp", 1300819380 }
			};

			string token = JWT.Encode(payload, "asd", JwsAlgorithm.HS256);
			return token;
		}
	}
}