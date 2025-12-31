using MelonLoader.Utils;
using UnityEngine.Rendering.PostProcessing;
using MelonLoader;

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
            if (sceneName == "RuralRegion")
            {
                Clones.ChangeObjects();
                GameObject.Find("STRSPAWN_BarnA_prefab(Clone)/Tech/TRIGGER_TemperatureIncrease_disabled").gameObject.SetActive(true);

                MelonCoroutines.Start(new ShootingRangeManager().PlaceAssetsAsync());
            }
        }
    }
}