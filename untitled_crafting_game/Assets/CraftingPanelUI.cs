using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingPanelUI : MonoBehaviour
{
    public static CraftingPanelUI Instance;

    // Start is called before the first frame update
    public Item item1;
    public Item item2;
    public Item resultingItem;

    public Image image1;
    public Image image2;
    public Image imageResult;

    public List<Recipe> recipes;

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

    public void SetItem(Item item)
    {
        if(item1 == null)
        {
            item1 = item;
            image1.sprite = item1.sprite;
        }
        else if(item2 == null)
        {
            item2 = item;
            image2.sprite = item2.sprite;
            //TODO: Check if the recipe exists!
            CheckRecipeBook();
        }
    }

    private void CheckRecipeBook()
    {
        foreach(Recipe recipe in recipes)
        {
            if( (recipe.item1 == item1 && recipe.item2 == item2) || (recipe.item1 == item2 && recipe.item2 == item1) )
            {
                print("RECIPE FOUND!");
                resultingItem = recipe.result;
                imageResult.sprite = recipe.result.sprite;
                break;
            }
        }

    }
}
