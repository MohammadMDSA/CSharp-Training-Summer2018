using System;

namespace VariablesAndPrimitiveTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			/// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#integral-types"/>
			int a = 1;
			Console.WriteLine(a);

			int b = a;
			Console.WriteLine(b);

			b = 3;
			Console.WriteLine(a);
			Console.WriteLine(b);


			byte c = 123;
			Console.WriteLine(c);


			char d = 's';
			Console.WriteLine(d);

			///<see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#integral-types"/>
			float e = 15434.234324f;
			Console.WriteLine(e);

			e = 145234e-13f;
			Console.WriteLine(e);


			double f = 14234321.10000001; // Omited value
			Console.WriteLine(f);


			/// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#integral-types"/>
			decimal g = 14234321.1000000000001m;
			Console.WriteLine(g);


			/// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#the-bool-type"/>

			bool h = true;
			Console.WriteLine(h);


			///<see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/lexical-structure#string-literals"/>
			string s = "hi!";
			Console.WriteLine(s);
			string s1 = s;
			Console.WriteLine(s1);

			s1 = "heyy";
			Console.WriteLine(s);
			Console.WriteLine(s1);

		}
	}
}
