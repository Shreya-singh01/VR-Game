using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;

public class AutoFindInteractableAffordance : MonoBehaviour
{
    // Start is called before the first frame update
   private void Awake(){
    GetComponent<XRInteractableAffordanceStateProvider>().interactableSource = GetComponentInParent<XRBaseInteractable>();
   }
}
