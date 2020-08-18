using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Item> inventory;

    public Image[] itemImages;

    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool AddItemToInventory(Item item)
    {
        if(inventory.Count >= 4)
        {
            print("YOU HAVE TOO MANY ITEMS!");
            return false;
        }
        else
        {
            inventory.Add(item);
            itemImages[inventory.Count - 1].sprite = item.sprite;

            return true;
        }
        
    }

    public Item GetItemAt(int index)
    {
        if(index >= inventory.Count)
        {
            print("ERROR! Out of bounds inventory!");
            return null;
        }

        return inventory[index];
    }

    
    
}

public enum ItemType
{
    ROCK,
    PAPER,
    WOOD,
    WATER,
    FIRE
}
