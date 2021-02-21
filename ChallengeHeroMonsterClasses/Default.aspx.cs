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

			Hero.Name = "Hero";
			Hero.Health = 200;
			Hero.DamageMaximum = 20;
			Hero.AttackBonus = true;

			Monster.Name = "Monster";
			Monster.Health = 200;
			Monster.DamageMaximum = 20;
			Monster.AttackBonus = false;

			int heroDamage = Hero.Attack(Dice);
			int monsterDamage = Monster.Attack(Dice);

			Monster.Defend(heroDamage);
			Hero.Defend(monsterDamage);

			resultLabel.Text =
				DisplayResult.PlayerStats(Hero) +
				DisplayResult.PlayerStats(Monster) +
				DisplayResult.RoundNumber(1) +
				DisplayResult.Battle(Hero, Monster, heroDamage, Monster.Health) + 
				DisplayResult.Battle(Monster, Hero, monsterDamage, Hero.Health);
		}
	}
}