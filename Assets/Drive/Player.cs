using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JUMP_VELOCITY_MAX = 5;

    public float MovementSpeed = 7.5f;
    public float JumpForce = 5; 
    public SpriteRenderer _spriteRenderer;
    public Animator _anim;
    public bool grounded;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");

        if(movement < 0)
        {
            _spriteRenderer.flipX = true;
            if(grounded == true)
            {
            _anim.SetInteger("speed",1);
            }
        }else
        {
            if(movement != 0)
            {
            _spriteRenderer.flipX =false;
            }
            if(movement != 0 && grounded == true)
            {
                _anim.SetInteger("speed",1);
            }
        
        }

        if(movement == 0)
        {
            _anim.SetInteger("speed",0);
        }

        transform.position += new Vector3(movement,0,0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            grounded = false;
            _anim.SetInteger("speed",0);
            _anim.SetBool("hover",true);

            if (rb.velocity.y < JUMP_VELOCITY_MAX) rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse); 
        }
    }
}
