using MelonLoader;
using UnityEngine;
using CombatMasterHack_Joelmatic;
using System;
using System.Collections;
using CombatMasterHack_Joelmatic.Menus;
using CombatMasterHack_Joelmatic.Cheats;

namespace CombatMasterHack_Joelmatic.Menus
{
    public class Menu
    {
        public static void CreateGUI(Options options)
        {

            if (options.isMenuShown)
            {
                float boxWidth = 300;
                float boxHeight = 150;
                float boxX = (Screen.width - boxWidth) / 2;
                float boxY = (Screen.height - boxHeight) / 2;
                Rect boxRect = new Rect(boxX, boxY, boxWidth, boxHeight);

                // Make a background box
                GUI.skin.box.fontSize = 15;
                GUI.Box(boxRect, "CM Unlocker - Made by Joelmatic#8817");

                // Calculate the position and size of the first button
                float buttonWidth = 150;
                float buttonHeight = 30;
                float buttonX = (boxWidth - buttonWidth) / 2;
                float buttonY = 40;
                Rect buttonRect1 = new Rect(boxX + buttonX, boxY + buttonY, buttonWidth, buttonHeight);

                // Draw the first button
                if (GUI.Button(buttonRect1, "Soft Unlocker"))
                {
                    options.isMenuShown = false;
                    options.isSUnlockerMenuShown = true;
                }

                
                // Calculate the position and size of the second button
                float buttonX2 = (boxWidth - buttonWidth) / 2;
                float buttonY2 = 80;
                Rect buttonRect2 = new Rect(boxX + buttonX2, boxY + buttonY2, buttonWidth, buttonHeight);

                // Draw the second button
                if (GUI.Button(buttonRect2, "Hard Unlocker"))
                {
                    options.isMenuShown = false;
                    options.isHUnlockerMenuShown = true;
                }

                /**
                // Calculate the position and size of the second button
                float buttonX3 = (boxWidth - buttonWidth) / 2;
                float buttonY3 = 120;
                Rect buttonRect3 = new Rect(boxX + buttonX3, boxY + buttonY3, buttonWidth, buttonHeight);

                // Draw the thrid button
                if (GUI.Button(buttonRect3, "test" + options.isUnlockerON))
                {
                    HUnlocker.MaxLevel();
                }
                **/
                
            }
        }
    }
}

