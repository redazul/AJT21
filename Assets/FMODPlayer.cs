using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODPlayer : MonoBehaviour
{
    [SerializeField]
    private string fEventCollect, fEventJump, fEventKick, fEventOuch, fEventRespawn, fEventShoot;

    private FMOD.Studio.EventInstance fInstanceCollect,
        fInstanceJump,
        fInstanceKick,
        fInstanceOuch,
        fInstanceRespawn,
        fInstanceShoot;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            PlayEvent(fInstanceKick, fEventKick);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayEvent(fInstanceOuch, fEventOuch);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayEvent(fInstanceRespawn, fEventRespawn);
        }
    }



    public void OnAnimJump()
    {
        PlayEvent(fInstanceJump, fEventJump);
    }

    public void Shoot()
    {
        PlayEvent(fInstanceShoot, fEventShoot);
    }



    private void PlayEvent(FMOD.Studio.EventInstance instance, string fEvent)
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fEvent);
        instance.start();
        instance.release();
    }
}
