using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recipe", menuName = "ScriptableObjects/Recipe", order = 1)]

public class Recipe : ScriptableObject
{
    public Item item1;
    public Item item2;
    public Item result;

}
