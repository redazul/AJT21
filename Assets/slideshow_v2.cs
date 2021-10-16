using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class slideshow_v2 : MonoBehaviour
{

    public Animator _anim;
    public int next=0;
    public Text _text;
    public float onFrame =0;
    public bool goNext = true;

    public FMODLevel1 fmodLevel1;
    public FMODLevel2 fmodLevel2;

    public string fmodEventCalculator;
    public string fmodEventRetry;

    bool wasPassCodeChecked;

    // Start is called before the first frame update
    void Start()
    {
        wasPassCodeChecked = false;
    }


    // Update is called once per frame
    void Update()
    {
                     if(next==13)
            {
            
             SceneManager.LoadScene("b_sea");
            }

        onFrame = _anim.GetCurrentAnimatorStateInfo(0).normalizedTime;

        Debug.Log(_anim.GetCurrentAnimatorStateInfo(0).normalizedTime);
        if(onFrame > 1 && next !=10 && goNext ==true && onFrame < 1.01  )
        {      
                goNext = false;
                next++;
                _anim.SetInteger("next",next);
           
                
        }

        if(onFrame < 0.5 )
        {      
                goNext = true;
                
        }

        

        passCode();


        if(Input.GetKeyDown("space") )
        {

            if(next!=10)
            {
            next++;
            }


            _anim.SetInteger("next",next);

             if(next == 10)
            {
                _text.text = "Code : ";
            }


        }


        // FMOD
        if (next == 9) fmodLevel1.Stop();


        if (!Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.anyKeyDown)
            {
                // player calculator sfx
                fmodLevel2.PlayEvent(fmodEventCalculator);
            }
        }
        
    }


    void passCode(){
                if(next == 10)
        {
             _text.text = _text.text + Input.inputString; 
            
            if(_text.text.Length == 9)
            {
                if(_text.text == "Code : 17")
                {
                    next++;
                    _anim.SetInteger("next",next);
                    _text.text = "<space>";
                }else{
                    _text.text = "Code : ";
                    StartCoroutine(FMODEventRetryAfterDelay());
                }

            }


        }

    }


    IEnumerator<WaitForSeconds> FMODEventRetryAfterDelay()
    {
        yield return new WaitForSeconds(0.175f);
        fmodLevel2.PlayEvent(fmodEventRetry);
    }

}
