using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public class NewDice
	{
		public int Sides { get; set; }

		private Random rollDice = new Random();
		public int Roll()
		{
			int _eyesNumber = rollDice.Next(1, this.Sides);

			return _eyesNumber;
		}
	}
}