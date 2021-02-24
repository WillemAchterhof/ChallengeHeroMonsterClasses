using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public class NewPlayer
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int DamageMaximum { get; set; }
		public bool AttackBonus { get; set; }

		public int Attack(NewDice _dice)
		{
			int _damage = _dice.Roll();

			return _damage;
		}
		public void Defend(int _damage)
		{
			this.Health -= _damage;
		}
	}
}