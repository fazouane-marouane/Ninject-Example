using System;
namespace testDI
{
	public interface IWeapon
	{
		string Id { get; }

		string Hit();
	}
}
