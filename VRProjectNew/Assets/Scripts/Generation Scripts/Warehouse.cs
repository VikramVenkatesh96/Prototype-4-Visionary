using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : MonoBehaviour
{
    public GameObject[] cereals;
    public GameObject[] milk;
    public GameObject[] cans;

    public GameObject[] GetRandomCereals(int numOfRows) {
        List<GameObject> randomCereals = new List<GameObject>();

        while (randomCereals.Count != numOfRows ){ 
            int index = Random.Range(0,cereals.Length - 1);
            if (!randomCereals.Contains(cereals[index]))
            {
                randomCereals.Add(cereals[index]);
            }
        }

        return randomCereals.ToArray();
    }
    public GameObject[] GetRandomMilk(int numOfRows)
    {
        GameObject[] randomMilk = new GameObject[numOfRows];

        for (int i = 0; i < numOfRows; ++i)
        {
            int index = Random.Range(0, milk.Length - 1);
            randomMilk[i] = milk[index];
        }

        return randomMilk;
    }
    public GameObject[] GetRandomCans(int numOfRows)
    {
        GameObject[] randomCans = new GameObject[numOfRows];

        for (int i = 0; i < numOfRows; ++i)
        {
            int index = Random.Range(0, cans.Length - 1);
            randomCans[i] = cans[index];
        }

        return randomCans;
    }

}
