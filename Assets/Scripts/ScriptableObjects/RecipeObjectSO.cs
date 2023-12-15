using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class RecipeObjectSO : ScriptableObject
{
    public List<KitchenObjectSO> kitchenObjectSOList;

    public string recipeName;
}
