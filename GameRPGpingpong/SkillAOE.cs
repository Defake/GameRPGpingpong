using System;

namespace GameRPGpingpong
{
	public class SkillAOE : Skill
	{
		public SkillAOE(int manaCost, double cooldown, Action<Character> skillAction) : base(manaCost, cooldown, skillAction)
		{
		}

		public void Cast(ref int manaOfCaster, Character[] targets) {
			PerformSkillCasting(ref manaOfCaster, targets);
		}

	}
}