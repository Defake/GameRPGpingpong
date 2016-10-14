using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	public abstract class Skill : GameObject
	{
		private readonly int _manaCost;
		private readonly double _cooldown;
		private readonly Action<Character> _skillAction;
		
		private double _cooldownTimeRemaining = 0;
		private double _lastTime;

		// Remember manacost, cooldown and what action the skill performs
		public Skill(int manaCost, double cooldown, Action<Character> skillAction)
		{
			_manaCost = manaCost;
			_cooldown = cooldown;
			_skillAction = skillAction;
		}

		public void Update(double deltaTime) {
			// reduce cooldown time
		}

		/// <summary>
		/// Find out can character use this skill or not 
		/// </summary>
		/// <param name="manaOfTheCaster">Character passes their manna as parameter 
		/// to find out it's enough or not</param>
		/// <returns>True = the character can use this skill. False = can't yet</returns>
		public bool IsAvailable(int manaOfTheCaster)
		{
			return _cooldownTimeRemaining <= 0 && manaOfTheCaster >= _manaCost;
		}

		/// <summary>
		/// Sets skill to cooldown
		/// </summary>
		public void SetToCooldown()
		{
			_cooldownTimeRemaining = _cooldown;
		}
		
		/// <summary>
		/// Performs the skill's action and sets cooldown on the skill
		/// </summary>
		/// <param name="manaOfTheCaster">Caster's mana. Mana will be reduced by manacost</param>
		/// <param name="targets">The characters which stats will be changed by this skill</param>
		protected void PerformSkillCasting(ref int manaOfTheCaster, params Character[] targets)
		{
			if (IsAvailable(manaOfTheCaster)) {
				foreach (Character ch in targets)
					_skillAction(ch);

				manaOfTheCaster -= _manaCost;
				SetToCooldown();
				
			} else
				Console.WriteLine("Not yet!");
		}

	}
}
