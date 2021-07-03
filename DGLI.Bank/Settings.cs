using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGLI.Bank
{
	public class Settings
	{
		public string TransactionSoundFilePath { get; set; }
		public string CongratulationsSoundFilePath { get; set; }
		public Dictionary<string, int> TransactionValues { get; set; }
		public string Password { get; set; }
	}
}
