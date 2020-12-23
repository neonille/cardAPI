using Jose;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Card_api.Services.JwtService
{
	public class JwtService : IJwtService
	{
		public async Task<string> NewSession()
		{
			var payload = new Dictionary<string, object>()
			{
				{ "sub", "mr.x@contoso.com" },
				{ "exp", 1300819380 }
			};

			var secretKey = new byte[] { 164, 60, 194, 0, 161, 189, 41, 38, 130, 89, 141, 164, 45, 170, 159, 209, 69, 137, 243, 216, 191, 131, 47, 250, 32, 107, 231, 117, 37, 158, 225, 234 };

			string token = Jose.JWT.Encode(payload, secretKey, JwsAlgorithm.HS256);
			return token;
		}
	}
}