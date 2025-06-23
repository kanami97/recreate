using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{

      public void change_button() //change_buttonという名前にします
        {
            SceneManager.LoadScene("mainscenes");//secondを呼び出します
        }
        
    
}
