using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRow : MonoBehaviour
{
    public int MAXNUMBER = 3;
    public bool autoUpdate;
    public GameObject parent;
    public GameObject[] stocks;
    public List<Vector3> startPositions;
    public float minGapBetweenObjects;
    public float maxGapBetweenObjects;
    
    //Currently works only for those shelves with default rotation
    public void GenerateItems() {

        List<float> offsets = new List<float>();

        if (startPositions.Count != stocks.Length)
        {   //Clear the start positions list
            startPositions.Clear();
            //Then add the required vectors
            for (int i = 0; i < stocks.Length; ++i)
            {
                startPositions.Add(new Vector3(0, 0, 0));
            }
        }

        // Generate all the items in the stocks
        for(int i = 0; i < stocks.Length; ++i)
        {
            offsets.Add(startPositions[i].z);
            GameObject stock = stocks[i];
            for (int j = 0; j < MAXNUMBER; ++j)
            {
                Vector3 position = new Vector3(startPositions[i].x, startPositions[i].y, offsets[i]);
                GameObject newItem = Instantiate(stock, position, stock.transform.rotation, parent.transform);
                newItem.name = stock.name + " " + j;
                offsets[i] -= Random.Range(minGapBetweenObjects, maxGapBetweenObjects);
            }
        }
    }

    public void DestroyItems() {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Items");
        foreach (GameObject item in items) {
            DestroyImmediate(item);
        }
    }
}
