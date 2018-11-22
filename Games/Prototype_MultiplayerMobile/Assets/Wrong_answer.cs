using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wrong_answer : MonoBehaviour {

    public string NextLevel;
    public void OnWrong()
    {
     
            Debug.Log("ChangeScene");
          //  block.GetComponent<Renderer>().material.color = Color.green;
            SceneManager.LoadScene("Wrong");
       
      
            Debug.Log("Error");
          //  block.GetComponent<Renderer>().material.color = Color.yellow;
        

    }
}
