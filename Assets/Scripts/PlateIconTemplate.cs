//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateIconTemplate : MonoBehaviour
{
    [SerializeField] private Image image;
    public void SetKitchenObjectSO(KitchenObjectScriptableObject  kitchenObjectSO)
    {
        image.sprite = kitchenObjectSO.sprite;
    }
}
