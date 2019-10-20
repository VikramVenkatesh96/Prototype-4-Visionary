using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenCerealRow : MonoBehaviour
{
    public int MAXNUMBER = 3;
    public bool autoUpdate;
    public GameObject stock;
    public Vector3 startPosition;
    public float minGapBetweenObjects;
    public float maxGapBetweenObjects;
    public void GenerateCereal() {
        float offset = startPosition.z;
        for (int i = 0; i < MAXNUMBER; ++i) { 
            Vector3 position = new Vector3(startPosition.x,startPosition.y, offset);
            Quaternion rotation = Quaternion.Euler(0,0,0);
            Instantiate(stock,position,rotation,stock.transform);
            offset -= Random.Range(minGapBetweenObjects, maxGapBetweenObjects);
        }
    }

    public void DestroyCereal() {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Items");
        foreach (GameObject item in items) {
            DestroyImmediate(item);
        }
    }
}
