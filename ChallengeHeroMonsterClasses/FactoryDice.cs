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
		public static NewDice Create(NewPlayer _player)
		{
			return new NewDice(_player);
		}
	}
}