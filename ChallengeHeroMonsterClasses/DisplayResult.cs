using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public class DisplayResult
	{
		private static string result = string.Empty;
		public static string PlayerStats(Player _player)
		{
			result = string.Format($"Name: {_player.Name}<br />" +
				$"Healht: {_player.Health}<br />" +
				$"Max Damage: {_player.DamageMaximun}<br />" +
				$"Attack Bonus: {_player.AttackBonus}<br /><br />");

			return result;
		}
		public static string RoundNumber(int _roundNumber)
		{
			result = string.Format($"<hr />Round Nunber: {_roundNumber}<br /><br />");

			return result;
		}
		public static string BonusRound()
		{
			result = string.Format($"<hr />Bonus Round<br />>");

			return result;
		}
		public static string Battle(Player _playerAtacker, Player _playerDefender, int _damage, int _health)
		{
			result = string.Format($"The {_playerAtacker.Name} deals {_damage} damage to the {_playerDefender.Name}." +
				$"<br />{_playerDefender.Name} has {_health} health left.<br /><br />");

			return result;
		}
	}
}