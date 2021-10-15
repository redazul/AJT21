using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tele : MonoBehaviour
{

 void OnTriggerEnter2D(Collider2D hitInfo)
    {
       
       if(hitInfo.name == "Player")
       {
           
            SceneManager.LoadScene("c_mountain");
       }
        
        
    }


}
