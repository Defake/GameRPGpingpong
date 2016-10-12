using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	public class Character
	{
		public readonly Stat health;
		public readonly Stat speed;
		public readonly Stat manaRegen;
		public readonly Stat defense;
		private int _currentMana;

		public List<Skill> skills { get; }

		public Character(int health, int speed, int manaRegen, int defense)
		{
			this.health = new Stat(health);
			this.speed = new Stat(speed);
			this.manaRegen = new Stat(manaRegen);
			this.defense = new Stat(defense);
			skills = new List<Skill>();
			_currentMana = 100;
		}

		public void LearnNewSkill(Skill skill) => skills.Add(skill);
		
		/* Here will be some player controls or AI system to cast skills */

	}
}
