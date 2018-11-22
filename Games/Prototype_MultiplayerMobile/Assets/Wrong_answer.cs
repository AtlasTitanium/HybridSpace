using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wrong_answer : MonoBehaviour {

    private void Start()
    {
        StartCoroutine(OnWrong());
    }
    public string NextLevel; 
   IEnumerator  OnWrong()
    {
        yield return new WaitForSeconds(2.0f);
            Debug.Log("ChangeScene");
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
            
      
        
        

    }
}
