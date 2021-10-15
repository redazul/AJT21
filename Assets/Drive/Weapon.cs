using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {
            _anim.Play("gun_shot_standing");
            Debug.Log("shoot");
            Shoot();
        }
        
    }


    void Shoot()
    {
        //Debug.Log(spriteRenderer.flipX);
        if (spriteRenderer.flipX)
        {
            spriteRotation =  new Quaternion(0, 0, 0, 0);
            Instantiate(bulletPrefab,firePointLeft.position,spriteRotation);
        }else{
            
            spriteRotation =  new Quaternion(0, 180, 0, 0);
            //Debug.Log(spriteRotation);
            Instantiate(bulletPrefab,firePoint.position,spriteRotation);

        }
        

    }
}
