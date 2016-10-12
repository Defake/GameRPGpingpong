using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{

	// This class represents buffs or debuffs
	public class Modificator
	{
		public readonly int modValue; // Can be positive or negative value
		private double _timeRemaining; // Remaining time in seconds
		private double _lastTime;

		public Modificator(int modValue, double timeRemaining)
		{
			this.modValue = modValue;
			_timeRemaining = timeRemaining;
			_lastTime = 0; //current system time
		}

		/// <summary>
		/// Find out either this modificator exists yet or existance time was already out
		/// </summary>
		/// <returns>True = modif. exists. False = modif.'s time was out</returns>
		public bool IsExisted()
		{
			var currentTime = 0; // Get current system time
			_timeRemaining -= currentTime - _lastTime;
			_lastTime = currentTime;

			return _timeRemaining > 0;
		}

	}
}
