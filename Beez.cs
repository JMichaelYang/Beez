using Terraria.ModLoader;

namespace Beez
{
	class Beez : Mod
	{
		public Beez()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
