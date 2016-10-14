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
			new SkillTarget(50, 100, character => character.defense.AddModificator(new Modificator(+40, 40)));

		public static Skill BulletEnergy() =>
			new SkillTarget(20, 15, character => character.speed.AddModificator(new Modificator(+50, 7)));

		// Heals by 15 every second during 5 seconds. 75 at all
		public static Skill TastyJuicefall() =>
			new SkillTarget(45, 80, character => character.health.AddModificator(new Modificator(+15, 5, true)));

		// Heals several characters by 20 during 4 sec.
		public static Skill HealingWall() =>
			new SkillAOE(60, 120, character => character.health.AddModificator(new Modificator(+20, 4, true)));

		// Negative skills
		public static Skill ArmorBreak() =>
			new SkillTarget(40, 50, character => character.defense.AddModificator(new Modificator(-10, 30)));

		public static Skill ManaBurn() =>
			new SkillTarget(35, 20, character => character.manaRegen.AddModificator(new Modificator(-30, 15)));

		// This skill will reduce character's mana by 8 every second during 10 seconds. 80 mana at all
		public static Skill ManaVoid() =>
			new SkillTarget(35, 140, character => character.manna.AddModificator(new Modificator(-8, 10, true)));

		// This AOE skill will sets all characters' skills to cooldown
		public static Skill ElectricShock() =>
			new SkillAOE(50, 80, character =>
			{
				foreach (Skill skill in character.skills)
					skill.SetToCooldown();
			});

	}
}
