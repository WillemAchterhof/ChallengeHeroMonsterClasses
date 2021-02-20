using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
	public class PlayerFactory
	{
		static public Player Create()
		{
			return new Player();
		}
	}
}