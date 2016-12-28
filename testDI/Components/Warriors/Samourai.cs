using System;
using Ninject;

namespace testDI
{
	public class Samourai: IWarrior
	{
		[Inject]
		[Named("Primary")]
		public IWeapon Weapon { get; set; }

		[Inject]
		public IWriter Writer { get; set; }

		public void Attack()
		{
			Writer.Log(Weapon.Hit());
		}
	}
}
