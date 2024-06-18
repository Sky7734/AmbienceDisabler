using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using RumbleModUI;
using UnityEngine.SceneManagement;

namespace AmbienceDisabler
{
    public class AmbienceDisablerClass : MelonMod
    {
        public AudioSource Ambience;
        public bool AmbienceBool = true;
//        RumbleModUI.UI UI;
//        Mod Mod = new Mod();
        public string SceneName;
/*
        public override void OnLateInitializeMelon()
        {
            base.OnLateInitializeMelon();

            UI = RumbleModUIClass.UI_Obj;

            List<Il2CppSystem.String> Whitelist = new List<Il2CppSystem.String>();

            Mod.SetName("Disable Ambience");
            Mod.SetVersion("1.2.0");
            Mod.SetFolder("DisableAmbience");

            Mod.AddToList("Description", ModSetting.AvailableTypes.Description, "", 0, "Disables the ambient birds in the gym and park.");
            Mod.AddToList("Disable", ModSetting.AvailableTypes.Boolean, "true", 1, "Set to \"true\" to disable ambience and \"false\" to enable.");

            Mod.GetFromFile();
        }
        public override void OnUpdate()
        {
            base.OnUpdate();

            if (UI.GetInit() && !Mod.GetUIStatus())
            {
                UI.AddMod(Mod);
            }

            if (SceneName == "Gym" && UI.IsUIVisible() || SceneName == "Park" && UI.IsUIVisible())
            {
                if (UI.IsModSelected(Mod.GetName()) && UI.IsOptionSelected("Disable"))
                {
                    AmbienceBool = Convert.ToBoolean(Mod.TempSettings[1].GetValue());
                    Ambience.mute = AmbienceBool;
                }
            }
        }
*/
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            SceneName = sceneName;
            if (sceneName == "Gym" || sceneName == "Park")
            {
                Ambience = GameObject.Find("Ambience").GetComponent<AudioSource>();
                Ambience.mute = AmbienceBool;
            }
        }
    }

}
