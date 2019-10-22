using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkout : MonoBehaviour
{
    private CheckItems check;
    public List<GameObject> shoppingList;

    void Start()
    {
        shoppingList = new List<GameObject>();

        //shoppingList.Add(GameObject.FindGameObjectWithTag("Items"));

        //a little manual effort but saves a lot of computations
        check = GameObject.FindGameObjectWithTag("Basket").transform.GetChild(5).GetComponent<CheckItems>();
    }
    void OnTriggerEnter(Collider other)
    {   /*Look at the output log for the item names 
        and write your code here*/
        //Get the item collider list
        List<Collider> basketItems = check.GetBasketItems();
        //Print them
        foreach (Collider item in basketItems) {
            foreach(GameObject item1 in shoppingList)
            {
                if (item == item1)
                {
                    print("Correct Item picked!");
                    break;
                }
            }
            Debug.Log(item.name);
        }
    }
}
