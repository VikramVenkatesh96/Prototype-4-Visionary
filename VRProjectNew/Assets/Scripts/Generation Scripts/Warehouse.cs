using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : MonoBehaviour
{
    public GameObject[] cereals;
    public GameObject[] milk;
    public GameObject[] cans;
    public GameObject[] chips;
    public GameObject[] GetRandomCereals(int numOfRows)
    {
        List<GameObject> randomCereals = new List<GameObject>();

        while (randomCereals.Count != numOfRows)
        {
            int index = Random.Range(0, cereals.Length - 1);
            //Check if variety exceed number of rows
            if (cereals.Length >= numOfRows)
            {
                //Make sure no two rows contain same items
                if (!randomCereals.Contains(cereals[index]))
                {
                    randomCereals.Add(cereals[index]);
                }
            }
            else
            {
                randomCereals.Add(cereals[index]);
            }
        }

        return randomCereals.ToArray();
    }
    public GameObject[] GetRandomMilk(int numOfRows)
    {
        List<GameObject> randomMilk = new List<GameObject>();

        while (randomMilk.Count != numOfRows)
        {
            int index = Random.Range(0, milk.Length - 1);
            if (milk.Length >= numOfRows)
            {
                if (!randomMilk.Contains(milk[index]))
                {
                    randomMilk.Add(milk[index]);
                }
            }
            else
            {
                randomMilk.Add(milk[index]);
            }
        }

        return randomMilk.ToArray();
    }
    public GameObject[] GetRandomCans(int numOfRows)
    {
        List<GameObject> randomCans = new List<GameObject>();

        while (randomCans.Count != numOfRows)
        {
            int index = Random.Range(0, cans.Length - 1);
            if (cans.Length >= numOfRows)
            {
                if (!randomCans.Contains(cans[index]))
                {
                    randomCans.Add(cans[index]);
                }
            }
            else
            {
                randomCans.Add(cans[index]);
            }
        }

        return randomCans.ToArray();

    }
    public GameObject[] GetRandomChips(int numOfRows)
    {
        List<GameObject> randomChips = new List<GameObject>();

        while (randomChips.Count != numOfRows)
        {
            int index = Random.Range(0, chips.Length - 1);
            if (chips.Length >= numOfRows)
            {
                if (!randomChips.Contains(chips[index]))
                {
                    randomChips.Add(chips[index]);
                }
            }
            else
            {
                randomChips.Add(chips[index]);
            }
        }

        return randomChips.ToArray();

    }
}
