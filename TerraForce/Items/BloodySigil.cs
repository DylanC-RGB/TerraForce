using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace TerraForce.Items
{
    public class BloodySigil : ModItem
    {
        public override void SetStaticDefaults() 
        {
            // DisplayName.SetDefault("BasicSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Summons the Blood Moon.");
        }

        public override void SetDefaults() 
        {
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.value = 10000;
            item.rare = 2;
            item.consumable = true;
	    item.maxStack = 99;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
        }
        public override bool CanUseItem(Player player) {
            return !Main.dayTime;
        }
        public override bool UseItem(Player player)
        {
            Main.NewText("There will be blood!", 150,0,0);
	    Main.bloodMoon = true;
            return true;
        }

        public override void AddRecipes() 
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MalignantTissue", 15);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}