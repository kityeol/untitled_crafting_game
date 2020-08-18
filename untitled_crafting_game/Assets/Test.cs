using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Item itemToGet;
    public Image inventoryImage;
    public Image myImage;

    public float timeTillRegen = 50000;

    public Sprite treeResourceReady;
    public Sprite treeResourceDepleted;

    public ItemType itemType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeTillRegen -= Time.deltaTime;
        if(timeTillRegen <= 0)
        {
            myImage.sprite = treeResourceReady;
        }
    }

    public void TEST_BUTTON_PRESS()
    {

        print("HELLO!");
        //if(myImage.sprite != treeResourceDepleted)
       // {
            bool success = GameManager.Instance.AddItemToInventory(itemToGet);
            if (success == true)
            {
                //Destroy(this.gameObject);
                //myImage.sprite = treeResourceDepleted;
            }
        //}
        //else
        //{
            print("you can't get anything from this stump!");
        //}
       
    }

}
