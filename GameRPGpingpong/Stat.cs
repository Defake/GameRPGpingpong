using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	// Represent different characteristics of characters
	public class Stat : GameObject 
	{
		private int _value;
		public int value
		{
			get
			{
				int val = _value;
				int k = 0;
				while (k < _modificators.Count)
				{
					if (_modificators[k].IsExisted() && !_modificators[k].continious)
						val += _modificators[k].modValue;

					k++;
				}

				return val;
			}

			set { _value = value; }
		}

		private readonly List<Modificator> _modificators;

		public Stat(int value)
		{
			_value = value;
			_modificators = new List<Modificator>();
		}

		public void AddModificator(Modificator mod)
		{
			_modificators.Add(mod);
		}

		public void Update(double deltaTime)
		{
			foreach (Modificator mod in _modificators)
			{
				mod.Update(deltaTime);

				// delete modificators which time was expired

				// Reduce stat's value if current modificator is continious
			}
		}
	}
}
