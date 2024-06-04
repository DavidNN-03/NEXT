using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject toggleObject;

    public void Interact()
    {
        if(toggleObject.activeInHierarchy) {
            toggleObject.SetActive(false);
        }
        else {
            toggleObject.SetActive(true);
        }
    }
}
