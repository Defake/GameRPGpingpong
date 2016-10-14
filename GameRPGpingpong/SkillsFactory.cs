using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{

	// This class defines some skill templates. Just for comfortability
	public static class SkillsFactory 
	{

		// Positive skills
		public static Skill StrengthOfGods() => 
			new Skill(50, character => character.defense.AddModificator(new Modificator(+40, 40)));

		public static Skill BulletEnergy() =>
			new Skill(20, character => character.speed.AddModificator(new Modificator(+50, 7)));

		// Heals by 15 every second during 5 seconds. 75 at all
		public static Skill TastyJuicefall() =>
			new Skill(45, character => character.health.AddModificator(new Modificator(+15, 5, true)));

		// Negative skills
		public static Skill ArmorBreak() =>
			new Skill(40, character => character.defense.AddModificator(new Modificator(-10, 30)));

		public static Skill ManaBurn() =>
			new Skill(35, character => character.manaRegen.AddModificator(new Modificator(-30, 15)));

		// This skill will reduce character's mana by 8 every second during 10 seconds. 80 mana at all
		public static Skill ManaVoid() =>
			new Skill(35, character => character.manna.AddModificator(new Modificator(-8, 10, true)));

	}
}
