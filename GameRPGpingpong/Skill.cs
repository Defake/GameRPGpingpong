using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	public class Skill
	{
		public readonly int manaCost;
		public readonly Action<Character> skillAction;

		private double _cooldown;
		private double _cooldownTimeRemaining = 0;
		private double _lastTime;

		// Remember manacost and what action the skill performs
		public Skill(int manaCost, Action<Character> skillAction)
		{
			this.manaCost = manaCost;
			this.skillAction = skillAction;
			_lastTime = 0; // curent system time
		}

		/// <summary>
		/// Find out can character use this skill or not 
		/// </summary>
		/// <param name="manaOfTheCaster">Character passes their currentMana as parameter 
		/// to find out it's enough or not</param>
		/// <returns>True = the character can use this skill. False = can't yet</returns>
		public bool IsAvailable(int manaOfTheCaster)
		{
			if (_cooldownTimeRemaining > 0)
			{
				var currentTime = 0; //current sys time
				_cooldownTimeRemaining -= currentTime - _lastTime;
				_lastTime = currentTime;
			}

			return _cooldownTimeRemaining <= 0 && manaOfTheCaster >= manaCost;
		}

		/// <summary>
		/// Performs the skill's action and sets cooldown on the skill
		/// </summary>
		/// <param name="manaOfTheCaster">Caster's mana. Mana will be reduced by manacost</param>
		/// <param name="target">The character which stats will be changed by this skill</param>
		public void Cast(ref int manaOfTheCaster, Character target)
		{
			if (IsAvailable(manaOfTheCaster))
			{
				skillAction(target);
				manaOfTheCaster -= manaCost;
				_cooldownTimeRemaining = _cooldown;
			} 
			else 
				Console.WriteLine("Not yet!");
		}

	}
}
