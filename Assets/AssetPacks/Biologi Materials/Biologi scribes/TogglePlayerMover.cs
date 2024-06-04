using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePlayerMover : MonoBehaviour, IInteractable
{
   public void Interact()
   {
        Character Controller playerMover = FindObjectOfType<Character Controller>();

        playerMover.enabled = !playerMover.enabled;
   }
}
