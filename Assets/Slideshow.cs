using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Slideshow : MonoBehaviour
{

    public GameObject[] _images;
    public int onSlide = 0;
    public Text _text;
    public VideoPlayer _vidPlayer;

    public 
    // Start is called before the first frame update
    void Start()
    {
        _text.text = "";
       Cursor.visible = false;
       _vidPlayer = _images[onSlide].GetComponent<VideoPlayer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log((ulong)_vidPlayer.frame);
        // Debug.Log((ulong)_vidPlayer.frameCount);

        if((ulong)_vidPlayer.frame == _vidPlayer.frameCount-1)
        {
             _text.text = "<Next>";
        }else{
            if(onSlide!=2)
            {
                
                _text.text = "";
            }
        }


        if(onSlide == 2)
        {
             _text.text = _text.text + Input.inputString; 
            
            if(_text.text.Length == 9)
            {
                if(_text.text == "Code : 17")
                {
                    onSlide++;
                _images[onSlide-1].SetActive(false);
                _vidPlayer = _images[onSlide].GetComponent<VideoPlayer>();
                _vidPlayer.Play();
                }else{
                    _text.text = "Code : ";
                }

            }

                // _images[onSlide].SetActive(true);
                // _images[onSlide-1].SetActive(false);
                // _text.text = "Code:_ _ <space to confirm>";
                // _text.text = _text.text

                // }else{
                // _images[onSlide-1].SetActive(false);
                // _vidPlayer = _images[onSlide].GetComponent<VideoPlayer>();
                // _vidPlayer.Play();

        }





        if (Input.GetKeyDown("space") && onSlide!=2)
        {
             onSlide++;
             //Debug.Log(_images.Length);
             if(onSlide >= _images.Length)
             {
                 
             //Debug.Log("Loading new scene");
             SceneManager.LoadScene("MountainLevel");
             }else{
                             if(onSlide == 2)
            {
                _text.text = "Code : ";
            _images[onSlide].SetActive(true);
            _images[onSlide-1].SetActive(false);

            }else{
            _images[onSlide-1].SetActive(false);
            _vidPlayer = _images[onSlide].GetComponent<VideoPlayer>();
            _vidPlayer.Play();
            }

             }




        }

 



        
        
    }
}
