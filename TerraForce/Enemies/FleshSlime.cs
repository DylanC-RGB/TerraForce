using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace TerraForce.Enemies
{
	public class FleshSlime : ModNPC
	{
		public override void SetStaticDefaults() 
		{
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];
		}

		public override void SetDefaults() 
		{
			npc.width = 32;
			npc.height = 28;
			npc.defense = 4;
			npc.damage = 27;
			npc.lifeMax = 33;
			npc.value = 7f;
			npc.aiStyle = 1;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			aiType = NPCID.GreenSlime;
			animationType = NPCID.GreenSlime;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (Main.bloodMoon)
			{
				return SpawnCondition.OverworldNight.Chance * 0.8f;
			}	
			return SpawnCondition.OverworldNight.Chance * 0.2f;
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
			if (Main.rand.Next(1,20) == 1)
			{
				Item.NewItem(npc.getRect(), ItemID.ZombieArm, 1);
			}
			Item.NewItem(npc.getRect(), mod.ItemType("MalignantTissue"), Main.rand.Next(1,2));
		}
	}
}