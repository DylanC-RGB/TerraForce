using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TerraForce.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class BloodyHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Bloody Helmet");
			Tooltip.SetDefault("How can you see when the blood is dripping into your eyes like that?");
		}

		public override void SetDefaults() {
			item.width = 24;
			item.height = 22;
			item.value = 60;
			item.rare = 2;
			item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<BloodyBreastplate>() && legs.type == ModContent.ItemType<BloodyGreaves>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Your thirst for blood has caused you to gain life at night, however at the cost of less during the day.";
			if (Main.dayTime)
			{
				player.statLifeMax2 -= 40;
			}
			if (!Main.dayTime)
			{
				player.statLifeMax2 += 40;
			}
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
