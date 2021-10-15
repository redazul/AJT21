using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_projectile : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.right * speed;        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if(hitInfo.name != "WorldRegion" && hitInfo.name != "waterplatform" && hitInfo.name != "bolt1(Clone)"  && hitInfo.name != "waterplatform 2" && hitInfo.name != "beam_cannon(Clone)" && hitInfo.name != "IMG_8848" && hitInfo.name != "Player" && hitInfo.name != "grounded")
        {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
        }
        
    }
}
