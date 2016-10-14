using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{

	// This class represents buffs or debuffs
	public class Modificator : GameObject
	{
		public readonly int modValue; // Can be positive or negative value
		public readonly bool continious;
		private double _timeRemaining; // Remaining time in seconds
		private double _lastTime;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="modValue">To reduce stat once or every second</param>
		/// <param name="timeRemaining">Remaining time...</param>
		/// <param name="continiously">Will a stat be reduced once or continiously</param>
		public Modificator(int modValue, double timeRemaining, bool continiously = false)
		{
			this.modValue = modValue;
			_timeRemaining = timeRemaining;
			_lastTime = 0; //current system time
			this.continious = continiously;
		}

		/// <summary>
		/// Find out either this modificator exists yet or existance time was already out
		/// </summary>
		/// <returns>True = modif. exists. False = modif.'s time was out</returns>
		public bool IsExisted()
		{
			return _timeRemaining > 0;
		}

		public void Update(double deltaTime)
		{
			// reduce time
		}
	}
}
