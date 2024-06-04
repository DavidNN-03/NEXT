using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMouse : MonoBehaviour, IInteractable
{
   public void Interact()
   {
        if(Cursor.lockState == CursorLockMode.Locked){
            Cursor.lockState = CursorLockMode.None;
        }
        else{
            Cursor.lockState = CursorLockMode.Locked;
        }
   }

}
