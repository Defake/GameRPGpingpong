using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	public class Character : GameObject 
	{
		public readonly Stat health;
		public readonly Stat speed;
		public readonly Stat manaRegen;
		public readonly Stat defense;
		public readonly Stat manna;
		
		public List<Skill> skills { get; }

		private readonly List<Stat> _stats; 

		public Character(int health, int speed, int manaRegen, int defense)
		{
			_stats.Add(this.health = new Stat(health));
			_stats.Add(this.speed = new Stat(speed));
			_stats.Add(this.manaRegen = new Stat(manaRegen));
			_stats.Add(this.defense = new Stat(defense));
			_stats.Add(manna = new Stat(100));
			skills = new List<Skill>();
		}

		public void LearnNewSkill(Skill skill) => skills.Add(skill);
		
		/* Here will be some player controls or AI system to cast skills */

		public void Update(double deltaTime)
		{
			foreach (Stat stat in _stats)
			{
				stat.Update(deltaTime);
			}
		}
	}
}
