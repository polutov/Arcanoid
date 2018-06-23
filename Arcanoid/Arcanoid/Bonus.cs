using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
	enum BonType { ExtraLife, ExtraBall, LongerPad, ShorterPad };

	class Bonus
	{
		public BonType BonusType { get; set; }
	}
}