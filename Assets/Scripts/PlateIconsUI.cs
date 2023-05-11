using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateIconsUI : MonoBehaviour
{
    [SerializeField] private PlateKitchenObject plateKitchenObject;
    [SerializeField] private Transform iconTemplate;

    private void Awake()
    {
        iconTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;
    }

    private void PlateKitchenObject_OnIngredientAdded(PlateKitchenObject.OnIngredientEventArgs obj)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        foreach(Transform child in transform)
        {
            if (child == iconTemplate) continue;

            Destroy(child.gameObject);
        }


        foreach(KitchenObjectScriptableObject kitchenObjectScriptableObject in plateKitchenObject.GetKitchenObjectScriptableObjects())
        {
            Transform iconTransform = Instantiate(iconTemplate, transform);
            iconTemplate.gameObject.SetActive(true);
            iconTransform.GetComponent<PlateIconTemplate>().SetKitchenObjectSO(kitchenObjectScriptableObject);
        }
    }
}
