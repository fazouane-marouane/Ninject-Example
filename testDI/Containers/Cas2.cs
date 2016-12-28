using System;
using Ninject.Extensions.NamedScope;
using Ninject.Modules;

namespace testDI
{
	public class ScopeObject { }

	public static class ProcessingScope
	{
		public static ScopeObject Current { get; set; }
	}
	
	public class Cas2 : NinjectModule
	{
		public override void Load()
		{
			Bind<IWeapon>().To<Sword>().InCallScope().Named("Primary");
			Bind<IWeapon>().To<Katana>().InCallScope().Named("Secondary");
			Bind<IWriter>().To<FancyWriter>();
			Bind<IWarrior>().To<Samourai>().Named("Samourai");
			Bind<IWarrior>().To<Ninja>().Named("Ninja");
		}
	}
}
