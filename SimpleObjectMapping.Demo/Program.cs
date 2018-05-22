using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObjectMapping.Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			var c1 = new ClassA() {Test = "Test1"};

			var mapper = new ObjectMapper();
			var c2 = mapper.Map<ClassB>(c1);
		}
	}
}
