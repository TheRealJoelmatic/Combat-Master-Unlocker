using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using CombatMasterHack_Joelmatic.Menus;
using CombatMasterHack_Joelmatic.Cheats;

namespace CombatMasterHack_Joelmatic
{
    class CombatMasterHack : MelonMod
    {
        Options options = new Options();

        public override void OnGUI()
        {
            Menu.CreateGUI(options);
            SoftUnlockerMenu.CreateGUI(options);
            HardUnlockerMenu.CreateGUI(options);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg($"Scene {sceneName} with build index {buildIndex} has been loaded!");
            options.isMenuShown = false;
        }

        public override void OnLateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                options.isMenuShown = !options.isMenuShown;
                options.isSUnlockerMenuShown = false;
                options.isHUnlockerMenuShown = false;
                MelonLogger.Msg($"Menu: " + options.isMenuShown);
            }
            if (options.isEspON)
            {
                //ESP.playerEsp();
            }
           
        }
    }
}
