using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPGpingpong 
{
	// Represent different characteristics of characters
	public class Stat
	{
		private readonly int _value;
		public int value
		{
			get
			{
				int val = _value;
				int k = 0;
				while (k < _modificators.Count)
				{
					if (_modificators[k].IsExisted())
					{
						val += _modificators[k].modValue;
						k++;
					}
					else
						_modificators.RemoveAt(k);
				}

				return val;
			}
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

	}
}
