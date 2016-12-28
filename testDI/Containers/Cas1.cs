using System;
using Ninject.Modules;

namespace testDI
{
	public class Cas1 : NinjectModule
	{
		public override void Load()
		{
			Bind<IWeapon>().To<Dagger>().InSingletonScope().Named("Primary");
			Bind<IWeapon>().To<Sword>().InSingletonScope().Named("Secondary");
			Bind<IWriter>().To<FancyWriter>();
			Bind<IWarrior>().To<Ninja>().Named("Ninja");
			Bind<IWarrior>().To<Samourai>().Named("Samourai");
		}
	}
}
