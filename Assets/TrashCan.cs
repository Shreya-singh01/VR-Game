using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start(){
        GetComponent<triggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }
    
    public void InsideTrash(GameObject go){
        go.SetActive(false);
    }
}
