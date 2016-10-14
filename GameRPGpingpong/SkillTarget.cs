using System;

namespace GameRPGpingpong
{
	public class SkillTarget : Skill
	{
		public SkillTarget(int manaCost, double cooldown, Action<Character> skillAction) : base(manaCost, cooldown, skillAction)
		{
		}

		public void Cast(ref int manaOfCaster, Character target)
		{
			PerformSkillCasting(ref manaOfCaster, target);
		}

	}
}