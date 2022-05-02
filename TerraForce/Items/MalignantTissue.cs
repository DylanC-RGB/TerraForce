using Terraria.ID;
using Terraria.ModLoader;

namespace TerraForce.Items
{
	public class MalignantTissue : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BasicSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It's dead, but it feels like it's trying to crawl out of your hands.");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 100;
			item.rare = 2;
			item.maxStack = 999;
		}
	}
}