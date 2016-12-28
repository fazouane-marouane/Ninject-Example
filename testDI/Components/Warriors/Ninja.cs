using System;
using Ninject;

namespace testDI
{
	public class Ninja: IWarrior
	{
		[Inject]
		public IWeapon[] Weapons { get; set; }

		[Inject]
		public IWriter Writer { get; set; }

		public void Attack()
		{
			foreach (var weapon in Weapons)
			{
				Writer.Log(weapon.Hit());
			}
		}
	}
}
