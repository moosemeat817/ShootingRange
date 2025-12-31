using MelonLoader.Utils;
using UnityEngine.AddressableAssets;
using Il2CppSystem;
using UnityEngine.UIElements;
using UnityEngine;
using Il2Cpp;
using MelonLoader;
using System.Collections;

namespace ShootingRange
{
    public class ShootingRangeManager : MonoBehaviour
    {
        public void PlaceTerrain()
        {
            string scene = GameManager.m_ActiveScene;
        }

        public IEnumerator PlaceAssetsAsync()
        {
            // Barn Plank
            yield return PlaceAssetAsync("OBJ_WoodPlankSingle",
                new Vector3(2373.116f, 132.6067f, 1090.667f),
                new Vector3(0, 31.8365f, 34f),
                new Vector3(1f, 1f, 2f));

            // Blind Plank
            yield return PlaceAssetAsync("OBJ_WoodPlankSingle",
                new Vector3(2377.806f, 130.8266f, 1105.236f),
                new Vector3(357.9999f, 281.746f, 34f),
                new Vector3(1.2f, 1f, 2f));
        }

        private IEnumerator PlaceAssetAsync(string prefabName, Vector3 pos, Vector3 rot, Vector3 scale)
        {
            GameObject prefab = null;
            yield return AssetUtils.LoadPrefabAsync(prefabName, (go) => prefab = go);

            if (prefab != null)
            {
                SceneUtils.PlaceAssetsInScene(prefabName, pos, rot, scale);
            }
            else
            {
                MelonLogger.Warning($"Failed to load prefab: {prefabName}");
            }
        }
    }
}