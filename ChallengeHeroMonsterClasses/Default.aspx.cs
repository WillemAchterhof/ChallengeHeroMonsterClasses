using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClasses
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			NewPlayer Hero = FactoryPlayer.Create();
			NewPlayer Monster = FactoryPlayer.Create();

			NewDice Dice = FactoryDice.Create();
			NewDice DiceBonusAttack = FactoryDice.Create(10);

			Hero.Name = "Hero";
			Hero.Health = 200;
			Hero.DamageMaximum = 20;
			Hero.AttackBonus = true;

			Monster.Name = "Monster";
			Monster.Health = 200;
			Monster.DamageMaximum = 20;
			Monster.AttackBonus = false;

			int roundCount = 0;
			
			string result =
				DisplayResult.PlayerStats(Hero) +
				DisplayResult.PlayerStats(Monster);

			while (Hero.Health > 0 && Monster.Health > 0)
			{
				roundCount++;

				int heroDamage = Hero.Attack(Dice);
				int monsterDamage = Monster.Attack(Dice);

				if (Hero.AttackBonus && DiceBonusAttack.Roll() == 5)
				{
					Monster.Defend(heroDamage); 
					result +=
						DisplayResult.BonusRound() +
						DisplayResult.Battle(Hero, Monster, heroDamage, Monster.Health);
				}
				if (Monster.AttackBonus && DiceBonusAttack.Roll() == 1)
				{
					Hero.Defend(monsterDamage); 
					result +=
						DisplayResult.BonusRound() +
						DisplayResult.Battle(Monster, Hero, monsterDamage, Hero.Health);
				}
					Hero.Defend(monsterDamage); 
					Monster.Defend(heroDamage); 

					result +=
				DisplayResult.RoundNumber(roundCount) +
				DisplayResult.Battle(Hero, Monster, heroDamage, Monster.Health) + 
				DisplayResult.Battle(Monster, Hero, monsterDamage, Hero.Health);
			}

			result += DisplayResult.BattleFinished(Hero, Monster);

			resultLabel.Text = result;
		}
	}
}