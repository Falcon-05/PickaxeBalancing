using Terraria.ModLoader;

namespace PickaxeBalancing
{
	public class PickaxeBalancing : Mod
	{
        internal static PickaxeBalancing Instance;

        public override void Load()
        {
            Instance = this;
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}