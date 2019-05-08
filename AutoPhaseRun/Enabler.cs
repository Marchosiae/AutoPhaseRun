using PoeHUD.Poe.Components;
using System;
using PoeHUD.Plugins;
using System.Windows.Forms;
using PoeHUD.Controllers;

namespace AutoPhaseRun
{
    public class Enabler : BaseSettingsPlugin<AutoPhaseRunSettings>
    {
        public int enabled = 1;
        public int Enabled()
        { 
              
            //Pause if Hideout, city or dead character
            if
                (GameController.Area.CurrentArea.IsHideout
                || GameController.Area.CurrentArea.IsTown
                || !GameController.Player.IsAlive
                || !Settings.Enable
                || GameController.Game.IngameState.Data.LocalPlayer.GetComponent<Life>().Buffs.Exists(b => b.Name == "grace_period")
                || GameController.Game.IngameState.IngameUi.InventoryPanel.IsVisible
                || GameController.Game.IngameState.IngameUi.OpenLeftPanel.IsVisible
                || GameController.Game.IngameState.IngameUi.AtlasPanel.IsVisible
                || GameController.Game.IngameState.IngameUi.OpenRightPanel.IsVisible
                || GameController.Game.IngameState.IngameUi.SyndicatePanel.IsVisible
                || GameController.Game.IngameState.IngameUi.IncursionWindow.IsVisible
                || GameController.Game.IngameState.IngameUi.TreePanel.IsVisible
                || GameController.Game.IngameState.IngameUi.HiddenSkillBar.IsVisible
                || GameController.Game.IngameState.UIRoot.GetChildFromIndices(1, 111).ChildCount > 0
                || Control.IsKeyLocked(Keys.CapsLock) == false)
            {
                enabled = 0;
                }
            return enabled;

            
        }
    }
}


