using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_api.Models
{
	public struct Card
	{
		public Suite Suite { get; set; }
		public Rank Rank { get; set; }
		public int Worth { get; set; }
		public string SuiteName
		{
			get => Suite.ToString();
		}
		public string RankName 
		{
			get => Rank.ToString();
				
		}
	}
}
