using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GenCerealRow))]
public class GenCerealRowEditor : Editor
{
    public override void OnInspectorGUI() {
        GenCerealRow generator = (GenCerealRow)target;
        if (DrawDefaultInspector()) {
            if (generator.autoUpdate) {
                if (GameObject.FindGameObjectWithTag("Items") != null)
                {
                    generator.DestroyCereal();
                }
                generator.GenerateCereal();
            }
        }
        if (GUILayout.Button("Generate!")) {
            if (GameObject.FindGameObjectWithTag("Items") != null)
            {
                generator.DestroyCereal();
            }
            generator.GenerateCereal();
        }
    }
}
