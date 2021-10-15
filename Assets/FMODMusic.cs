using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODMusic : MonoBehaviour
{
    [SerializeField]
    string fEventMusic;

    private FMOD.Studio.EventInstance fInstanceMusic;

    void Start()
    {
        fInstanceMusic = FMODUnity.RuntimeManager.CreateInstance(fEventMusic);
        fInstanceMusic.start();
    }

    private void OnDestroy()
    {
        fInstanceMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        fInstanceMusic.release();
    }
}
