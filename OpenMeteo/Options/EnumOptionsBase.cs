using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OpenMeteo.Options
{
	public abstract class EnumOptionsBase<T> : IEnumerable<Enum>, ICollection<Enum> where T : Enum
	{
		/// <summary>
		/// A copy of the current applied parameter. This is a COPY. Editing anything inside this copy won't be applied 
		/// </summary>
		public List<Enum> Parameters { get { return new List<Enum>(_parameters); } }

		public int Count => _parameters.Count;

		public bool IsReadOnly => false;

		private readonly List<Enum> _parameters;

		public EnumOptionsBase(Enum parameter)
		{
			_parameters = new List<Enum>();
			Add(parameter);
		}

		public EnumOptionsBase(params Enum[] parameter)
		{
			_parameters = new List<Enum>();
			Add(parameter);
		}

		public EnumOptionsBase()
		{
			_parameters = new List<Enum>();
		}

		public Enum this[int index]
		{
			get { return _parameters[index]; }
			set
			{
				_parameters[index] = value;
			}
		}

		/// <summary>
		/// Any Enum value may be added.
		/// </summary>
		/// <param name="param"></param>
		public void Add(Enum param)
		{
			// Check that the parameter isn't already added
			if (_parameters.Contains(param)) return;

			_parameters.Add(param);
		}

		public void Add(params Enum[] param)
		{
			foreach (HourlyOptionsParameter paramToAdd in param)
			{
				Add(paramToAdd);
			}
		}

		public IEnumerator<Enum> GetEnumerator()
		{
			return _parameters.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Clear()
		{
			_parameters.Clear();
		}

		public bool Contains(Enum item)
		{
			return _parameters.Contains(item);
		}

		public void CopyTo(Enum[] array, int arrayIndex)
		{
			_parameters.CopyTo(array, arrayIndex);
		}

		public bool Remove(Enum item)
		{
			return _parameters.Remove(item);
		}
	}
}
