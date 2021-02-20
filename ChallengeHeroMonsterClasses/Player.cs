using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public class Player
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public int DamageMaximun { get; set; }
		public bool AttackBonus { get; set; }

		Random assingnDamage = new Random();

		public int Attack()
		{
			int _damage = assingnDamage.Next(this.DamageMaximun);

			return _damage;
		}
		public void Defend(int _damage)
		{
			this.Health -= _damage;
		}
	}
}