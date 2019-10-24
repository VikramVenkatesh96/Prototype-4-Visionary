using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingListGenerator : MonoBehaviour
{
    public GameObject[] items;
    public List<string> shoppingList;
    public List<string> checkoutList;
    public GenRow genRow;

    string[] enumType =
    {
        "CerealBox",
        "Can",
        "Milk"
    };

    string[] enumCereal =
    {
        "Kellogg's Corn Flakes",
        "Cheerios",
        "Kellogg's Rice Krispies",
        "Kellogg's Mini Wheats",
        "Kellogg's All-Bran",
        "Kellogg's Crispix",
        "Kellogg's Frosted Mini Wheats"
    };

    string[] enumCan =
    {
        "Coke",
        "Coke Zero",
        "Diet Coke",
        "Mtn Dew",
        "Pepsi",
        "Sprite"
    };

    string[] enumMilk =
    {
        "Fat Free Milk",
        "1% Milk",
        "2% Milk",
        "Whole Milk"
    };

    // Start is called before the first frame update
    void Start()
    {

        items = new GameObject[genRow.stocks.Length];

        for (int i = 0; i < genRow.stocks.Length; i++)
        {
            items[i] = genRow.stocks[i];
        }

        ListGenerator();
    }

    public void ListGenerator()
    {

        shoppingList = new List<string>();
        //add 3 random items into shoppingList with their generic type name
        for (int i = 0; i < 4; i++)
        {
            //gte a random item name from the items array
            string temp = (items[Random.Range(0, items.Length - 1)]).name;
            while (shoppingList.Contains(temp))
            {
                //makes sure the same item does not appear again in the shopping list
                temp = (items[Random.Range(0, items.Length - 1)]).name;
            }
            shoppingList.Add(temp);
        }

        checkoutList = new List<string>();

        for (int i = 0; i < shoppingList.Count; i++)
        {
            checkoutList.Add(shoppingList[i]);
        }

        //goes through the shopping list and updates the name to be the name shown on the list itself
        for (int i = 0; i < shoppingList.Count; i++)
        {
            //if item is a cereal box
            if (shoppingList[i].Split('_')[0].CompareTo(enumType[0]) == 0)
            {
                //item is CerealBox_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumCereal[0];
                   
                }
                //item is CerealBox_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumCereal[1];
                  
                }
                //item is CerealBox_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumCereal[2];
                    
                }
                //item is CerealBox_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumCereal[3];
                   
                }
                //item is CerealBox_5
                else if (shoppingList[i].Split('_')[1].CompareTo("5") == 0)
                {
                    shoppingList[i] = enumCereal[4];
                   
                }
                //item is CerealBox_6
                else if (shoppingList[i].Split('_')[1].CompareTo("6") == 0)
                {
                    shoppingList[i] = enumCereal[5];
                    
                }
                //item is CerealBox_7
                else if (shoppingList[i].Split('_')[1].CompareTo("7") == 0)
                {
                    shoppingList[i] = enumCereal[6];
                    
                }
            }
            //if item is a can
            else if (shoppingList[i].Split('_')[0].CompareTo(enumType[1]) == 0)
            {
                //item is Can_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumCan[0];
                }
                //item is Can_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumCan[1];
                }
                //item is Can_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumCan[2];
                }
                //item is Can_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumCan[3];
                }
                //item is Can_5
                else if (shoppingList[i].Split('_')[1].CompareTo("5") == 0)
                {
                    shoppingList[i] = enumCan[4];
                }
                //item is Can_6
                else if (shoppingList[i].Split('_')[1].CompareTo("6") == 0)
                {
                    shoppingList[i] = enumCan[5];
                }

            }
            //if item is milk
            else
            {
                //item is Milk_1
                if (shoppingList[i].Split('_')[1].CompareTo("1") == 0)
                {
                    shoppingList[i] = enumMilk[0];
                }
                //item is Milk_2
                else if (shoppingList[i].Split('_')[1].CompareTo("2") == 0)
                {
                    shoppingList[i] = enumMilk[1];
                }
                //item is Milk_3
                else if (shoppingList[i].Split('_')[1].CompareTo("3") == 0)
                {
                    shoppingList[i] = enumMilk[2];
                }
                //item is Milk_4
                else if (shoppingList[i].Split('_')[1].CompareTo("4") == 0)
                {
                    shoppingList[i] = enumMilk[3];
                }
            }
        }

        //print the shopping list onto the gameObject itself
        for(int i = 0; i < shoppingList.Count; i++)
        {
            gameObject.GetComponent<TextMesh>().text += (i+1).ToString() + "." + " " + shoppingList[i] + "\n";
        }


    }
}
