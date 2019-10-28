using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRow : MonoBehaviour
{

    //temporary arrangement to stop ShoppingListGenerator from throwing errors
    public GameObject[] stocks;
    public int maxNumber = 3;
    public bool autoUpdate;
    public float minGapBetweenObjects;
    public float maxGapBetweenObjects;
    private List<Vector3> startPositions;
    private List<Vector3> endPositions;
    private GameObject[] Shelves;
    private Warehouse wareHouse;
    
    //Currently works only for those shelves with default rotation
    public void GenerateItems() {

        startPositions = new List<Vector3>();
        endPositions = new List<Vector3>();
        Shelves = GameObject.FindGameObjectsWithTag("Shelf");
        wareHouse = gameObject.GetComponentInChildren<Warehouse>();

        foreach (GameObject shelf in Shelves)
        {
            //store the startPositions and endPositions in a list for later ease of calculations 
            int numOfRows = shelf.transform.GetChild(1).childCount;
            
            //Store startPositions and endPositions for the current shelf
            for (int i = 0; i < numOfRows; ++i)
            {
                //Debug.Log()
                startPositions.Add(shelf.transform.GetChild(1).GetChild(i).transform.position);
                endPositions.Add(shelf.transform.GetChild(2).GetChild(i).transform.position);

            }

            //Set the stock for that particular shelf
            Shelf shelfComponent = shelf.GetComponent<Shelf>();
            
            //Currently configured for cereals. To add: mechanism to control for other type of objects
            shelfComponent.stock = wareHouse.GetRandomCereals(numOfRows);

            //Find parent items GameObject
            GameObject parent = shelf.transform.Find("Items").gameObject;

            //Populate the Shelf for each row in the shelf
            for (int i = 0; i < numOfRows; ++i)
            {
                PopulateShelf(i, shelfComponent.stock[i] ,parent);
            }

            //Clear all lists before adding again
            startPositions.Clear();
            endPositions.Clear();

        }

    }

    public void DestroyItems() {

        GameObject[] items = GameObject.FindGameObjectsWithTag("Items");
        foreach (GameObject item in items) {
            DestroyImmediate(item);
        }
    }

    private void PopulateShelf(int rowNumber, GameObject stock, GameObject parent)
    {
        float offset = 0;

        for (int i = 0; i < maxNumber; ++i)
        {
            Vector3 newPos = startPositions[rowNumber] + (endPositions[rowNumber] - startPositions[rowNumber]).normalized * offset;
            Instantiate(stock, newPos, parent.transform.rotation, parent.transform);
            offset += Random.Range(minGapBetweenObjects, maxGapBetweenObjects);
        }
    }

}

