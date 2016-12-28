using System;
namespace testDI
{
	public class Sword : AbstractWeapon
	{
		public override string Hit()
		{
			return $"[{Id}] Slice in half";
		}
	}
}
