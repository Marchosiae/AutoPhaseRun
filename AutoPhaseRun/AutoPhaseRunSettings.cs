using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using System.Windows.Forms;
namespace AutoPhaseRun
{
    public class AutoPhaseRunSettings : SettingsBase
    {
        public AutoPhaseRunSettings()
        {
            delay = new RangeNode<int>(4, 1, 10);
            pressedKey = Keys.W;
        }
       
        [Menu("Key", 1)]
        public HotkeyNode pressedKey { get; set; }

        [Menu("Delay After Pressing Key", 2)]
        public RangeNode<int> delay { get; set; }
    }
}
