using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraForce.Items
{
    [AutoloadEquip(EquipType.Legs)]
    public class ChlorophyllGreaves : ModItem
    {
        public override void SetStaticDefaults() {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Bloody Greaves");
            Tooltip.SetDefault("Isn't that supposed to be spelt grieves?\n+10 Max Life");
        }

        public override void SetDefaults() {
            item.width = 22;
            item.height = 20;
            item.value = 40;
            item.rare = 2;
            item.defense = 2;
        }

        public override void UpdateEquip(Player player) {

            player.statLifeMax2 += 10;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MalignantTissue", 15);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
