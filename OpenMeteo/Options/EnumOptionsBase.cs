using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenMeteo.Options
{
	public abstract class EnumOptionsBase<T> : IEnumerable<Enum>, ICollection<Enum> where T : Enum
	{
		/// <summary>
		/// A copy of the current applied parameter. This is a COPY. Editing anything inside this copy won't be applied 
		/// </summary>
		public List<Enum> Parameters { get { return new List<Enum>(_parameters); } }

		/// <summary>
		/// Parameter Count
		/// </summary>
		public int Count => _parameters.Count;

		/// <summary>
		/// 
		/// </summary>
		public bool IsReadOnly => false;

		private readonly List<Enum> _parameters;

		/// <summary>
		/// 
		/// </summary>
		public EnumOptionsBase(Enum parameter)
		{
			_parameters = new List<Enum>();
			Add(parameter);
		}

		/// <summary>
		/// 
		/// </summary>
		public EnumOptionsBase(params Enum[] parameter)
		{
			_parameters = new List<Enum>();
			Add(parameter);
		}

		/// <summary>
		/// 
		/// </summary>
		public EnumOptionsBase()
		{
			_parameters = new List<Enum>();
		}

		/// <summary>
		/// 
		/// </summary>
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

		/// <summary>
		/// 
		/// </summary>
		public void Add(params Enum[] param)
		{
			foreach (Enum paramToAdd in param)
			{
				Add(paramToAdd);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public IEnumerator<Enum> GetEnumerator()
		{
			return _parameters.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <summary>
		/// 
		/// </summary>
		public void Clear()
		{
			_parameters.Clear();
		}

		/// <summary>
		/// 
		/// </summary>
		public bool Contains(Enum item)
		{
			return _parameters.Contains(item);
		}

		/// <summary>
		/// 
		/// </summary>
		public void CopyTo(Enum[] array, int arrayIndex)
		{
			_parameters.CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// 
		/// </summary>
		public bool Remove(Enum item)
		{
			return _parameters.Remove(item);
		}
	}
}
