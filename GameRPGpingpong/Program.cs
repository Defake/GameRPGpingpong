using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	class Program 
	{
		static void Main(string[] args)
		{
			new Skill(5, character => character.health.AddModificator(new Modificator(-10, 30)));
		}
	}
}
