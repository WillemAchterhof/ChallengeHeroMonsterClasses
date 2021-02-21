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
		public int Roll(int _sides)
		{
			int _eyesNumber = rollDice.Next(1, _sides);

			return _eyesNumber;
		}
		public NewDice()
		{
			this.Sides = 0;
		}
		public NewDice(NewPlayer _player)
		{
			this.Sides = _player.DamageMaximum;
		}
	}
}