using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boss_movement : MonoBehaviour
{

    public float speed = 1.0f;
    private Vector3 target1;
    private Vector3 target2;
    private Vector3 target3;
    private float nextActionTime = 3.0f;
    public float period = 3f;
    public Vector3[] _positions;
    public int index =0;

    public Transform firePoint;
    public Transform firePointLeft;
    public GameObject bulletPrefab;
    public Transform Player;
    public SpriteRenderer spriteRenderer;
    Quaternion spriteRotation;

    public Image _healthBar;
    public int health =300;
    public GameObject _hpPosition;
    public float push=0;
    public int HitDamage = 1;
    public Animator _anim;
    public GameObject _teleport;
    // Start is called before the first frame update
    void Start()
    {
        target1= new Vector3(-6.2f, 88.1f, 0f);
        target2= new Vector3(-6.2f, 89.27f, 0f);
        target3= new Vector3(-6.2f, 90.74f, 0f);

      
       
    }

    // Update is called once per frame
    void Update()
    {
 
         if (Time.time > nextActionTime ) {
         nextActionTime += period;
         // execute block of code here
         if(index <2)
         {
             
         index=index+1;
         }else{
             index=0;
         }
         

        }

        if(health>0)
        {
                    float step =  speed * Time.deltaTime; // calculate distance to move
        if(index==0)
        {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target1, step);
        
      

        }

               if(index==1)
        {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target2, step);
                
        }

                if(index==2)
        {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target3, step);
                
        } 

        }


    }

    void fire()
    {
        Instantiate(bulletPrefab,firePointLeft.position,spriteRotation);
    }

        void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("boss hit");
        Debug.Log(hitInfo.name);
        health = health-HitDamage;

        _healthBar.rectTransform.sizeDelta = new Vector2(health, 10);



        if(health <= 0)
        {
            
            float step =  speed * Time.deltaTime; // calculate distance to move
            this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(-6.2f,88.11f,0), step);
            _anim.SetBool("dead",true);
            _teleport.SetActive(true);
        }
        
        
    }



}
