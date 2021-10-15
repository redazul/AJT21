using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{

    public Animator _anim;
    public Player _PlayerScript;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        _anim.SetBool("hover",false);
       _PlayerScript.grounded = true;
    
        // if(hitInfo.name != "WorldRegion" && hitInfo.name != "bolt1(Clone)" )
        // {
        // Destroy(gameObject);
        // }
        
    }
}
