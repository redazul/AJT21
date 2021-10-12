using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slideshow : MonoBehaviour
{

    public GameObject[] _images;
    public int onSlide = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
             onSlide++;
             Debug.Log(_images.Length);
             if(onSlide == _images.Length)
             {
             Debug.Log("Loading new scene");
             SceneManager.LoadScene("MountainLevel");
             }

             if(onSlide <= _images.Length-1)
             {
            Debug.Log("Next Slide");
            _images[onSlide].SetActive(true);
            _images[onSlide-1].SetActive(false);

             }



        }
        
    }
}
