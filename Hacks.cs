﻿namespace LeagueSharp.Common
{
    /// <summary>
    /// Adds hacks to the menu.
    /// </summary>
    internal class Hacks
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        internal static void Initialize()
        {
            CustomEvents.Game.OnGameLoad += delegate
            {
                var menu = new Menu("Hacks", "Hacks");

                var draw = menu.AddItem(new MenuItem("DrawingHack", "Disable Drawing").SetValue(false));
                draw.SetValue(LeagueSharp.Hacks.DisableDrawings);
                draw.ValueChanged += (sender, args) => LeagueSharp.Hacks.DisableDrawings = args.GetNewValue<bool>();

                var say = menu.AddItem(new MenuItem("SayHack", "Disable L# Send Chat").SetValue(false)
                            .SetTooltip("Block Game.Say from Assemblies"));
                say.SetValue(LeagueSharp.Hacks.DisableSay);
                say.ValueChanged += (sender, args) => LeagueSharp.Hacks.DisableSay = args.GetNewValue<bool>();

                /*
                var zoom = menu.AddItem(new MenuItem("ZoomHack", "Extended Zoom").SetValue(false));
                zoom.SetValue(LeagueSharp.Hacks.ZoomHack);
                zoom.ValueChanged += (sender, args) => LeagueSharp.Hacks.ZoomHack = args.GetNewValue<bool>();

                menu.AddItem(new MenuItem("ZoomHackInfo", "Note: ZoomHack may be unsafe!") { FontStyle = FontStyle.Regular, FontColor = new ColorBGRA(255, 255, 0, 0) });         
                */

                var tower = menu.AddItem(new MenuItem("TowerHack", "Show Tower Ranges").SetValue(false));
                tower.SetValue(LeagueSharp.Hacks.TowerRanges);
                tower.ValueChanged += (sender, args) => LeagueSharp.Hacks.TowerRanges = args.GetNewValue<bool>();

                CommonMenu.Config.AddSubMenu(menu);
            };
        }
    }
}