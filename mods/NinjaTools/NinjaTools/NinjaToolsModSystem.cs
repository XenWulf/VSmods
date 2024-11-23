using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

//  NinjaTools Includes
using NinjaTools.Items;

namespace NinjaTools
{
    public class NinjaToolsModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            //api.Logger.Notification("Hello from template mod: " + api.Side);

            //  Register Item(s)
            {
                //Mod.Info.ModID 
                //  Smoke Bomb
                api.RegisterItemClass(Mod.Info.ModID + ".smokebombitem", typeof(ItemSmokeBomb));
            }
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            //api.Logger.Notification("Hello from template mod server side: " + Lang.Get("ninjatools:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            //api.Logger.Notification("Hello from template mod client side: " + Lang.Get("ninjatools:hello"));
        }

    }
}
