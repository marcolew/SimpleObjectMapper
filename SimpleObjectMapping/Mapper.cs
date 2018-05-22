using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObjectMapping
{
	public class ObjectMapper
	{
		public object Map<T>(object s) where T :new()
		{
			T resu = new T();
			foreach (PropertyInfo propertyInfo in s.GetType().GetProperties())
			{
				if (propertyInfo.CanRead)
				{
					foreach (PropertyInfo propertyInfo2 in resu.GetType().GetProperties())
					{
						if (propertyInfo.CanWrite)
						{
							if (propertyInfo.Name == propertyInfo2.Name)
							{
								object firstValue = propertyInfo.GetValue(s);
								try
								{
									propertyInfo2.SetValue(resu, firstValue);
								}
								catch (Exception)
								{
									
									throw;
								}
							}

						}
					}

				}
			}
			return resu;
		}
	}
}
