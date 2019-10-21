using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GenRow))]
public class GenRowEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GenRow generator = (GenRow)target;
        if (DrawDefaultInspector())
        {
            if (generator.autoUpdate)
            {
                if (GameObject.FindGameObjectWithTag("Items") != null)
                {
                    generator.DestroyItems();
                }
                generator.GenerateItems();
            }
        }
        if (GUILayout.Button("Generate!"))
        {
            if (GameObject.FindGameObjectWithTag("Items") != null)
            {
                generator.DestroyItems();
            }
            generator.GenerateItems();
        }

        if (GUILayout.Button("Destroy All!"))
        {
            if (GameObject.FindGameObjectWithTag("Items") != null)
            {
                generator.DestroyItems();
            }
        }
    }
}
