using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace ReducedGrinding.Items
{
	public class Expert_Change_Potion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Expert Change Potion");
			Tooltip.SetDefault("Switches World Difficulty in Single Player.");
		}
		
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.rare = 0;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.value = Item.buyPrice(0, 0, 1);
			item.UseSound = SoundID.Item3;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			if (Main.netMode == NetmodeID.SinglePlayer) // Single Player
				return true;
			else
				return false;
		}

		public override bool UseItem(Player player)
		{
			if (Main.netMode == NetmodeID.SinglePlayer) // Single Player
			{
				if (Main.expertMode)
					Main.NewText("World difficulty is now Normal Mode.", 255, 255, 0);
				else
					Main.NewText("World difficulty is now Expert Mode.", 207, 136, 255);
			}
			Main.expertMode = (!Main.expertMode);
			return true;
		}
	}
}