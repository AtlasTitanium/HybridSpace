using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class BtnPress : MonoBehaviour{
	public string NextLevel;
    public string WrongLevel;
	public GameObject block;
    public static int count = 0;

    public void NextScene(){
		try {
			Debug.Log("ChangeScene");
			block.GetComponent<Renderer>().material.color = Color.green;
        	SceneManager.LoadScene(NextLevel , LoadSceneMode.Single);
            count++;
        }
		catch (Exception e) {
			Debug.Log("Error");
			block.GetComponent<Renderer>().material.color = Color.yellow;
		}
    }
   

    public void OnWrong()
    {
        try
        {
            Debug.Log("ChangeScene");
            block.GetComponent<Renderer>().material.color = Color.green;
            SceneManager.LoadScene(WrongLevel, LoadSceneMode.Single);
        }
        catch (Exception e)
        {
            Debug.Log("Error");
            block.GetComponent<Renderer>().material.color = Color.yellow;
        }

    }

}
