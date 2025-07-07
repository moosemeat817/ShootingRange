using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ShootingRange
{
    public class Clones : MonoBehaviour
    {


        public static string[,] itemDataArray =
        {
            {"0_Scene",              "1_Name"},

            {"RuralRegion",  "OBJ_BullseyeTarget_Prefab"},
            {"RuralRegion",  "OBJ_SignYieldB_Prefab"},
            {"RuralRegion",  "OBJ_WeathervaneA_Prefab"},
            {"RuralRegion",  "OBJ_HayCartA_Prefab"},

            {"RuralRegion",  "OBJ_WoodStand_B_Prefab (2)"},
            {"RuralRegion",  "OBJ_WoodStand_A_Prefab (1)"},
            {"RuralRegion",  "STRSPAWN_BarnA_prefab"},

            {"RuralRegion",  "STRSPAWN_HuntersBlind_Prefab"},

            {"RuralRegion",  "OBJ_FlagPole_Prefab"},

            {"RuralRegion",  "OBJ_FenceWood_Tall2_PostB_Prefab (1)"},




        };

        public static void ChangeObjects()
        {

            GameObject findTargetGO = new GameObject();



            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 1]) == null)
                {
                    //MelonLogger.Msg("ChangeObject is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 1]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // -------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 0]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------


                    // ==============================================================================================================
                    // Pleasant Valley
                    // ==============================================================================================================

                   

                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FenceWood_Tall2_PostB_Prefab (1)" && !GameObject.Find("OBJ_FenceWood_Tall2_PostB_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2370.227f, 131.1382f, 1089.617f),
                                Quaternion.Euler(0f, 300.2029f, 359.6f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------







                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2372.488f, 124.0955f, 1213.973f),
                                Quaternion.Euler(-0f, 179.5536f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2411.858f, 122.4955f, 1197.813f),
                                Quaternion.Euler(-0f, 208.0688f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(3f, 3f, 3f);
                        }
                        // ------------------------------------------------------------------------------------------





                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab4(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2371.122f, 124.8955f, 1157.431f),
                                Quaternion.Euler(-0f, 181.037f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab5(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2391.595f, 124.7955f, 1140.954f),
                                Quaternion.Euler(-0f, 206.6999f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------







                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab6(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2397.312f, 127.3836f, 1107.773f),
                                Quaternion.Euler(7f, 303.7789f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab7(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2420.471f, 123.890f, 1127.736f),
                                Quaternion.Euler(7f, 277.5281f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab8(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2438.115f, 122.3273f, 1112.845f),
                                Quaternion.Euler(7f, 292.7614f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(3f, 3f, 3f);
                        }
                        // ------------------------------------------------------------------------------------------








                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab9(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2427.889f, 122.9955f, 1147.68f),
                                Quaternion.Euler(7f, 243.8759f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab10(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2415.471f, 123.6955f, 1161.529f),
                                Quaternion.Euler(-0f, 219.2506f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab11(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2385.733f, 124.8955f, 1169.436f),
                                Quaternion.Euler(7f, 199.6989f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------



                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab12(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2406.316f, 129.4503f, 1088.476f),
                                Quaternion.Euler(-0f, 312.9699f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------



                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_BullseyeTarget_Prefab" && !GameObject.Find("OBJ_BullseyeTarget_Prefab13(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2371.293f, 123.4503f, 1204.695f),
                                Quaternion.Euler(-0, 194.6425f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(3f, 3f, 3f);
                        }
                        // ------------------------------------------------------------------------------------------






                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_WeathervaneA_Prefab" && !GameObject.Find("OBJ_WeathervaneA_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2375.434f, 126.0955f, 1121.502f),
                                Quaternion.Euler(0, 0f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                        }
                        // ------------------------------------------------------------------------------------------



                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2363.291f, 122.3955f, 1172.173f),
                                Quaternion.Euler(-0f, 168.6447f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(2f, 2f, 2f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2359.875f, 124.1483f, 1140.554f),
                                Quaternion.Euler(-0f, 153.3264f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab3(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2396.543f, 121.9955f, 1186.455f),
                                Quaternion.Euler(-0f, 195f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(2f, 2f, 2f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab4(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2412.916f, 123.5955f, 1146.159f),
                                Quaternion.Euler(-0f, 214.4752f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------








                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab5(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2432.726f, 123.7295f, 1096.784f),
                                Quaternion.Euler(7f, 302.9274f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab6(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2452.473f, 115.6569f, 1125.248f),
                                Quaternion.Euler(7f, 247.6375f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(3f, 3f, 2f);
                        }
                        // ------------------------------------------------------------------------------------------




                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab7(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2392.776f, 123.3955f, 1156.601f),
                                Quaternion.Euler(7f, 211.0903f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_SignYieldB_Prefab" && !GameObject.Find("OBJ_SignYieldB_Prefab8(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2402.616f, 129.734f, 1071.078f),
                                Quaternion.Euler(7f, 349.2475f, 359f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------






                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_HayCartA_Prefab" && !GameObject.Find("OBJ_HayCartA_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2378.831f, 123.1955f, 1114.828f),
                                Quaternion.Euler(349.8234f, 0f, 359.9f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------


                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_HayCartA_Prefab" && !GameObject.Find("OBJ_HayCartA_Prefab2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2375.303f, 123.2255f, 1118.487f),
                                Quaternion.Euler(349.8234f, 94.8176f, 359.9f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------





                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "STRSPAWN_BarnA_prefab" && !GameObject.Find("STRSPAWN_BarnA_prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2372.606f, 131.0049f, 1092.567f),
                                Quaternion.Euler(-0f, 300.2477f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);
                        }
                        // ------------------------------------------------------------------------------------------




                        // Target ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "STRSPAWN_HuntersBlind_Prefab" && !GameObject.Find("STRSPAWN_HuntersBlind_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(2378.489f, 127.6721f, 1109.355f),
                                Quaternion.Euler(-0f, 276.1179f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.25f, 1f, 1.5f);
                        }
                        // ------------------------------------------------------------------------------------------


              



                }

            }

        }

    }
}
