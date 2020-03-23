using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHandler : MonoBehaviour
{
    //Inventory made up of a fixed set objects with variable maximums
    //
    public List<InventoryItem> InventoryList;
    public Image selectedImage;
    public Text selectedRemaining;

    private int indexSelected = 0;
    private string currentSelectedName;

    // Start is called before the first frame update
    void Start()
    {
        currentSelectedName = InventoryList[indexSelected].name;
    }

    // Update is called once per frame
    void Update()
    {
        bool changeImage = false;
        //check for scroll or number buttons to switch
        //up positive
        if (Input.mouseScrollDelta.y > 0)
        {
            if(indexSelected == 0)
            {
                indexSelected = InventoryList.Count - 1;
            }
            else
            {
                indexSelected--;
            }
            changeImage = true;
        }

        if (Input.mouseScrollDelta.y < 0)
        {
            if(indexSelected == InventoryList.Count - 1)
            {
                indexSelected = 0;
            }
            else
            {
                indexSelected++;
            }
            changeImage = true;
        }
        if (changeImage)
        {
            selectedImage.sprite = InventoryList[indexSelected].ItemSprite;
            selectedRemaining.text = InventoryList[indexSelected].CurrentCount.ToString() + "/" + InventoryList[indexSelected].MaxCount.ToString();

        }

        //handle the activation
        if (Input.GetMouseButton(0))
        {
            activateItem(InventoryList[indexSelected].name);
        }
    }

    public bool addToInventory(string itemAdd)
    {
        foreach(InventoryItem currentItem in InventoryList)
        {
            if(currentItem.name == itemAdd)
            {
                if (currentItem.CurrentCount < currentItem.MaxCount)
                {
                    currentItem.CurrentCount++;
                    return true;
                }
            }
        }
        return false;
    }

    void activateItem(string itemUsed)
    {
        print("Using this item: " + itemUsed);

        switch (itemUsed)
        {
            case "":

                break;
            default:
                break;
        }
    }

}

