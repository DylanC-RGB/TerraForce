using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerraForce.Items
{
    public class TrapperClassDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
		if (npc.type == NPCID.BloodZombie)
		{
			Item.NewItem(npc.getRect(), mod.ItemType("MalignantTissue"), Main.rand.Next(1,2));
		}
		if (npc.type == NPCID.Drippler)
		{
			Item.NewItem(npc.getRect(), mod.ItemType("MalignantTissue"), Main.rand.Next(2,3));
		}
        }
    }
}