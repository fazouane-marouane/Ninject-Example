using System;
using Ninject;

namespace testDI
{
	public class FancyWriter : IWriter
	{
		[Inject]
		[Named("Primary")]
		public IWeapon Weapon { get; set; }

		public void Log(string message)
		{
			Console.WriteLine($"✨{message}✨ With primary weapon {Weapon.Id}");
		}
	}
}
