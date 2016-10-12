using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	public class GameManager
	{

		private readonly List<Character> _characters;

		public GameManager()
		{
			_characters = new List<Character>();
		}

		public void StartGame()
		{
			// We can create characters, manage them, place them into some rooms or do another game stuff
			// But characters only cast their skills themselves. By players' controls or AI or something else

			Character zelda = new Character(100, 100, 100, 100);
			zelda.LearnNewSkill(SkillsFactory.ArmorBreak());
			zelda.LearnNewSkill(SkillsFactory.StrengthOfGods());

			Character thief = new Character(80, 140, 150, 45);
			thief.LearnNewSkill(SkillsFactory.BulletEnergy());
			thief.LearnNewSkill(SkillsFactory.ManaBurn());

			_characters.Add(zelda);
			_characters.Add(thief);
		}
	}
}
