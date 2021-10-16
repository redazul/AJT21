using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODLevel4 : MonoBehaviour
{
    public FMODUnity.StudioEventEmitter emitter;
    public Transform player;

    float initY;
    float goalY = 5.5f;

    private void Start()
    {
        initY = player.position.y;
        float distToGoal = goalY - player.position.y;
    }

    private void Update()
    {
        print("PROGRESS=" + (player.position.y - initY));
        emitter.SetParameter("Progress", player.position.y - initY);
    }
}
