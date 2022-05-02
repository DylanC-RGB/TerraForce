using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraForce.Items
{
    [AutoloadEquip(EquipType.Body)]
    public class BloodyBreastplate : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Bloody Breastplate");
            Tooltip.SetDefault("It feels like it's still alive...\n+10 Max Life");
        }

        public override void SetDefaults() {
            item.width = 26;
            item.height = 28;
            item.value = 40;
            item.rare = 2;
            item.defense = 4;
        }

        public override void UpdateEquip(Player player) {

            player.statLifeMax2 += 10;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MalignantTissue", 30);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
