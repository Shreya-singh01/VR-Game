using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlaySteps : MonoBehaviour
{
    PlayableDirector director;
    public List<Step> steps;
    // Start is called before the first frame update
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }

    [System.Serializable]

    public class Step{
        public string name;
        public float time;
        public bool hasPlayed = false;

    }

    // Update is called once per frame
    public void PlayStepIndex (int Index)
    {
        Step step = steps[Index];
        if (!step.hasPlayed){
            step.hasPlayed = true;

            director.Stop();
            director.time = step.time;
            director.Play();
        }
    }
}
