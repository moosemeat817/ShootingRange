using MelonLoader.Utils;
using UnityEngine.Rendering.PostProcessing;

namespace ShootingRange
{

    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();    

        }



        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {

           
            if (sceneName == "RuralRegion" && Settings.options.enableRange)
            {
                Clones.ChangeObjects();
                GameObject.Find("STRSPAWN_BarnA_prefab(Clone)/Tech/TRIGGER_TemperatureIncrease_disabled").gameObject.SetActive(true);

                new ShootingRangeManager().PlaceAssets();
            }


        }

    }
}
