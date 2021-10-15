using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODLevel1 : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter emitter;
    public FMODLevel2 fmodLevel2;

    public float Progress_Slides = 0;
    public float timeScale = 0.3875f;


    private void Update()
    {
        Progress_Slides += Time.deltaTime * timeScale;
        emitter.SetParameter("Progress_Slides", Progress_Slides);
    }


    public void Stop()
    {
        fmodLevel2.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
