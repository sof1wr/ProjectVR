using UnityEngine;
using UnityEditor;

public class FindMissingScripts : MonoBehaviour
{
    [MenuItem("Tools/Find Missing Scripts In Selected Prefabs")]
    public static void FindMissingScriptsInSelected()
    {
        GameObject[] go = Selection.gameObjects;
        int go_count = 0, components_count = 0, missing_count = 0;
        foreach (GameObject g in go)
        {
            go_count++;
            Component[] components = g.GetComponents<Component>();
            for (int i = 0; i < components.Length; i++)
            {
                components_count++;
                if (components[i] == null)
                {
                    missing_count++;
                    Debug.Log(g.name + " has a missing script at position: " + i, g);
                }
            }
        }

        Debug.Log($"Searched {go_count} GameObjects, {components_count} components, found {missing_count} missing.");
    }
}
