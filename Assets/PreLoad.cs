using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PreLoad : MonoBehaviour
{
    private VideoPlayer _vidPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        _vidPlayer = this.GetComponent<VideoPlayer>();
        _vidPlayer.Prepare();
    }


}
