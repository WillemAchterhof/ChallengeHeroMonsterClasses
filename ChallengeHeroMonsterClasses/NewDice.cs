using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public class NewDice
	{
		public int Sides { get; set; }

		public NewDice(int _sides = 0)
		{
			this.Sides = _sides;
		}
		public NewDice(NewPlayer _player)
		{
			this.Sides = _player.DamageMaximum;
		}
	}
}
