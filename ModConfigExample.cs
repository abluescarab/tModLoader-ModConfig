using Microsoft.Xna.Framework.Graphics;
using ModConfiguration;
using Terraria.ModLoader;

namespace ModConfigExample {
    class ModConfigExample : Mod {
        // create the new mod config
        public static readonly ModConfig Config = new ModConfig("ModConfigExample");

        // constants for the option names
        private const string ConfigOptionInt = "configOptionInt";
        private const string ConfigOptionBool = "configOptionBool";
        private const string ConfigOptionArray = "configOptionArray";

        public ModConfigExample() {
            Properties = new ModProperties() {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };

            // add the options to the configuration file
            Config.Add(ConfigOptionInt, 0);
            Config.Add(ConfigOptionBool, true);
            Config.Add(ConfigOptionArray, new string[] { "a", "b", "c" });
            // load the config, writing to a new file if it doesn't exist
            Config.Load();
        }

        public override void PostDrawInterface(SpriteBatch spriteBatch) {
            if((bool)Config.Get(ConfigOptionBool)) {
                // do something
            }
        }
    }
}
