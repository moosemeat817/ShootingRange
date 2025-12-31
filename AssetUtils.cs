using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using MelonLoader;

namespace ShootingRange
{
    internal static class AssetUtils
    {
        public static Dictionary<string, GameObject> cachedPrefabs = new Dictionary<string, GameObject>();
        static Dictionary<string, bool> loadingPrefabs = new Dictionary<string, bool>();

        public static IEnumerator LoadPrefabAsync(string prefabName, Action<GameObject> onComplete)
        {
            if (cachedPrefabs.ContainsKey(prefabName) && cachedPrefabs[prefabName] != null)
            {
                onComplete?.Invoke(cachedPrefabs[prefabName]);
                yield break;
            }

            if (loadingPrefabs.ContainsKey(prefabName) && loadingPrefabs[prefabName])
            {
                while (loadingPrefabs[prefabName])
                {
                    yield return null;
                }
                onComplete?.Invoke(cachedPrefabs[prefabName]);
                yield break;
            }

            loadingPrefabs[prefabName] = true;
            yield return MelonCoroutines.Start(GeneratePrefabAsync(prefabName, onComplete));
            loadingPrefabs[prefabName] = false;
        }

        private static IEnumerator GeneratePrefabAsync(string prefabName, Action<GameObject> onComplete)
        {
            GameObject go = new GameObject();
            go.name = prefabName;

            MeshFilter mf = go.AddComponent<MeshFilter>();
            MeshRenderer mr = go.AddComponent<MeshRenderer>();
            MeshCollider mc = go.AddComponent<MeshCollider>();

            AsyncOperationHandle<Mesh> meshHandle = default;
            AsyncOperationHandle<Material> materialHandle = default;

            switch (prefabName)
            {
                case "OBJ_WoodPlankSingle":
                    meshHandle = Addressables.LoadAssetAsync<Mesh>("Assets/ArtAssets/Env/Structures/STR_CoastalHouseG/OBJ_WoodPlankSingle.fbx");
                    yield return meshHandle;

                    materialHandle = Addressables.LoadAssetAsync<Material>("Assets/ArtAssets/Materials/Global/GLB_WallWoodNatural_B_Flat01.mat");
                    yield return materialHandle;

                    mf.sharedMesh = meshHandle.Result;
                    mr.sharedMaterial = materialHandle.Result;
                    mc.sharedMesh = mf.sharedMesh;
                    break;
            }

            cachedPrefabs[prefabName] = go;
            onComplete?.Invoke(go);
        }
    }
}