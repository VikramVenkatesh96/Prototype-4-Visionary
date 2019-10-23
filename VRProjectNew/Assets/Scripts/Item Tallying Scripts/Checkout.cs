using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkout : MonoBehaviour
{
    private CheckItems check;
    public List<GameObject> shoppingList;

    void Start()
    { 
        //a little manual effort but saves a lot of computations
        check = GameObject.FindGameObjectWithTag("Basket").transform.GetChild(5).GetComponent<CheckItems>();
    }
    void OnTriggerEnter(Collider other)
    {   /*Look at the output log for the item names 
        and write your code here*/
        //Get the item collider list
        List<string> basketItems = check.GetBasketItems();

        for(int i = 0; i < basketItems.Count; i++)
        {
            basketItems[i] = basketItems[i].Split(' ')[0];
        }

        //Print them
        foreach (GameObject item in shoppingList)
        {
            if (basketItems.Contains(item.name))
            {
                Debug.Log("Correct Item picked: " + item.name);
            }
            Debug.Log("Item name: " + item.name);
        }
    }
}
