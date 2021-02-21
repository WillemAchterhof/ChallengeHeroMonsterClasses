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

		public int Attack(int _rollResult,  int _mainHandWeapon = 0, int _offHandWeapon = 0)
		{
			int _damage =  _rollResult + _mainHandWeapon + _offHandWeapon;

			return _damage;
		}
		public void Defend(int _damage)
		{
			this.Health -= _damage;
		}
	}
}