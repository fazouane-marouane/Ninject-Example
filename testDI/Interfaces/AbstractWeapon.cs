using System;
namespace testDI
{
	public abstract class AbstractWeapon: IWeapon
	{
		public string Id { get; } = Guid.NewGuid().ToString("D");

		public abstract string Hit();
	}
}
