using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODLevel2 : MonoBehaviour
{
    public void PlayEvent(string fEvent)
    {
        FMOD.Studio.EventInstance instance = FMODUnity.RuntimeManager.CreateInstance(fEvent);
        instance.start();
        instance.release();
    }
}
