using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;



public class DisableGrabbingHandModel : MonoBehaviour
{
    public GameObject leftHandModel;
    public GameObject rightHandmodel;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    public void HideGrabbingHand(SelectEnterEventArgs args){
        if(args.interactorObject.tranform.tag == "Left Hand"){
            leftHandModel.SetActive(false);        
        }
        else if(args.interactorObject.tranform.tag == "Right Hand"){
            rightHandmodel.SetActive(false);
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args){
        if(args.interactorObject.tranform.tag == "Left Hand"){
            leftHandModel.SetActive(true);        
        }
        else if(args.interactorObject.tranform.tag == "Right Hand"){
            rightHandmodel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
