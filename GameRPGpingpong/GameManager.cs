using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	public class GameManager
	{

		private readonly List<GameObject> _gameContainer;

		public GameManager()
		{
			_gameContainer = new List<GameObject>();
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

			_gameContainer.Add(zelda);
			_gameContainer.Add(thief);

			while (true)
			{
				var dt = 0; // get delta time

				// Players play the game. Controls, events lalallal etc
				foreach (var o in _gameContainer)
					o.Update(dt);
			}

		}
	}
}
