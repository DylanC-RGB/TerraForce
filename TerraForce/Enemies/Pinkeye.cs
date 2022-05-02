using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace TerraForce.Enemies
{
	public class Pinkeye : ModNPC
	{
		public override void SetStaticDefaults() 
		{
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];
		}

		public override void SetDefaults() 
		{
			npc.width = 36;
			npc.height = 22;
			npc.defense = 6;
			npc.damage = 21;
			npc.lifeMax = 71;
			npc.value = 7f;
			npc.aiStyle = 2;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			aiType = NPCID.DemonEye;
			animationType = NPCID.DemonEye;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNight.Chance * 0.1f;	
		}
		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter++;
			if (npc.frameCounter >= 20)
			{
				npc.frameCounter = 0;
			}
			npc.frame.Y = (int)npc.frameCounter / 10 * frameHeight;
		}
		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("PinkLens"), Main.rand.Next(1,2));
		}
	}
}