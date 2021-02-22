using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public static class FactoryDice
	{ 
		 public static NewDice Create()
		{
			return new NewDice();
		}
		public static NewDice Create(New player _player)
		{
                        NewDice.Sides = _player.DamageMaximum;
			return new NewDice(_sides);
		}
	}
}
