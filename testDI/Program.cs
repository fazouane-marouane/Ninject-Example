using System;
using Ninject;

namespace testDI
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var kernel1 = new StandardKernel(new Cas1());
			var kernel2 = new StandardKernel(new Cas2());
			var scope = new ScopeObject();
			ProcessingScope.Current = scope;

			Console.WriteLine("Cas1");
			var ninja1 = kernel1.Get<IWarrior>("Ninja");
			var samourai1 = kernel1.Get<IWarrior>("Samourai");
			ninja1.Attack();
			samourai1.Attack();

			Console.WriteLine("Cas2");
			var ninja2 = kernel2.Get<IWarrior>("Ninja");
			var samourai2 = kernel2.Get<IWarrior>("Samourai");
			ninja2.Attack();
			samourai2.Attack();
			//Console.ReadKey();
		}
	}
}
