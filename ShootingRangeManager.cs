using MelonLoader.Utils;
using UnityEngine.AddressableAssets;
using Il2CppSystem;
using UnityEngine.UIElements;
using UnityEngine;
using Il2Cpp;


namespace ShootingRange
{
    public class ShootingRangeManager :MonoBehaviour
    {

        public void PlaceTerrain()
        {
            string scene = GameManager.m_ActiveScene;

            /*
            // Forsaken Log Bridge
            GameObject logBridge = GameObject.Find("OBJ_LogBridge_D Variant 2");

            Vector3 position = new Vector3(485.3372f, 271.4397f, -1238.838f);
            Vector3 rotation = new Vector3(0.5093f, 224.9446f, 33.6f);
            Vector3 scale = new Vector3(1, 1, 1);

            SceneUtils.InstantiateObjectInScene(logBridge, position, rotation, scale);
            */
           

        }






        public void PlaceAssets()
        {
            

            // Barn Plank
            Vector3 position = new Vector3(2373.116f, 132.6067f, 1090.667f);
            Vector3 rotation = new Vector3(0, 31.8365f, 34f);
            Vector3 scale = new Vector3(1f, 1f, 2f);

            SceneUtils.PlaceAssetsInScene("OBJ_WoodPlankSingle", position, rotation, scale);


            // Blind Plank
            Vector3 position2 = new Vector3(2377.806f, 130.8266f, 1105.236f);
            Vector3 rotation2 = new Vector3(357.9999f, 281.746f, 34f);
            Vector3 scale2 = new Vector3(1.2f, 1f, 2f);

            SceneUtils.PlaceAssetsInScene("OBJ_WoodPlankSingle", position2, rotation2, scale2);


        }

    }
}
