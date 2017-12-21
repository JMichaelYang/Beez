using Terraria.ID;
using Terraria.ModLoader;

namespace Beez.Items
{
	public class BeezGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Beez Gun");
			Tooltip.SetDefault("Summons bees that will chase your enemy");
		}

		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.BeeGun);
            item.magic = false;
            item.summon = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeGun, 1);
            recipe.AddIngredient(ItemID.BeeWax, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
