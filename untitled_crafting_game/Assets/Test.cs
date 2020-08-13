using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Item itemToGet;
    public Image inventoryImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TEST_BUTTON_PRESS()
    {
        print("HELLO!");
        inventoryImage.sprite = itemToGet.sprite;
    }

}
