using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODLevel3 : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter emitter;
    public Transform player;

    float initX;
    float goalX = -5.75f;

    private void Start()
    {
        initX = player.position.x;
    }

    private void Update()
    {
        float progress = player.position.x - initX;

        if (progress < 7f)
        {
            emitter.SetParameter("Progress L3", player.position.x - initX);
        }
    }
}
