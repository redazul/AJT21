using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_atk : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePointLeft;
    public GameObject bulletPrefab;
    public Transform Player;
    public SpriteRenderer spriteRenderer;
    public Animator _anim;
    Quaternion spriteRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Shoot();
        
        
    }


    void Shoot()
    {
       
     Instantiate(bulletPrefab,firePointLeft.position,spriteRotation);
      

    }
}
