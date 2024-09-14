using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timeToBreak =2;
    private float timer = 0;
    public UnityEvent OnBreak;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in breakablePieces){
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    public void Break(){
        timer += Time.deltaTime;

        if(timer> timeToBreak){
            foreach(var item in breakablePieces){
            item.SetActive(true);
            item.transform.parent = null;
        }


        OnBreak.Invoke();

        gameObject.SetActive(false);
        }
        
    }
}
