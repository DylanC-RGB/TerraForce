using Terraria.ID;
using Terraria.ModLoader;

namespace TerraForce.Items
{
	public class PinkLens : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BasicSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Despite the this item's creature of origin, it seems to work better than the original lens.");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 22;
			item.value = 100;
			item.rare = 2;
			item.maxStack = 999;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("PinkLens"), 4);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(ItemID.SuspiciousLookingEye, 1);
			recipe.AddRecipe();
		}
	}
}