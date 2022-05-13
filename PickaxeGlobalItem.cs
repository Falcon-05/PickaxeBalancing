using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PickaxeBalancing
{
	public class PickaxeGlobalItem : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			switch (item.type)
			{
				//Pre-Hardmode
				case ItemID.CactusPickaxe:
					item.useTime = 15;
					break;

				case ItemID.CopperPickaxe:
					item.useTime = 14;
					break;

				case ItemID.TinPickaxe:
					item.useTime = 13;
					break;

				case ItemID.IronPickaxe:
					item.useTime = 12;
					break;

				case ItemID.LeadPickaxe:
					item.useTime = 11;
					break;

				case ItemID.SilverPickaxe:
					item.useTime = 17;
					item.pick = 50;
					break;

				case ItemID.TungstenPickaxe:
					item.useTime = 16;
					break;

				case ItemID.GoldPickaxe:
					item.useTime = 15;
					break;

				case ItemID.FossilPickaxe:
					item.useTime = 13;
					break;

				case ItemID.NightmarePickaxe:
					item.useTime = 14;
					item.pick = 70;
					break;

				case ItemID.MoltenPickaxe:
					item.useTime = 16;
					break;

				//Hardmode
				case ItemID.CobaltPickaxe:
					item.useTime = 12;
					break;

				case ItemID.PalladiumPickaxe:
					item.useTime = 11;
					break;

				case ItemID.AdamantitePickaxe:
					item.useTime = 7;
					break;

				case ItemID.SpectrePickaxe:
					item.useTime = 8;
					break;

				case ItemID.SolarFlarePickaxe:
				case ItemID.VortexPickaxe:
				case ItemID.NebulaPickaxe:
				case ItemID.StardustPickaxe:
					item.useTime = 5;
					break;

				//Drills
				case ItemID.PalladiumDrill:
					item.useTime = 6;
					break;

				case ItemID.MythrilDrill:
					item.useTime = 5;
					break;

				case ItemID.OrichalcumDrill:
					item.useTime = 4;
					break;

				case ItemID.AdamantiteDrill:
				case ItemID.TitaniumDrill:
				case ItemID.Drax:
				case ItemID.ChlorophyteDrill:
					item.useTime = 3;
					break;

				case ItemID.LaserDrill:
					item.pick = 210;
					break;

				default:
					break;
			}
		}
	}
}