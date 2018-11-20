using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class BtnPress : MonoBehaviour{
	public string NextLevel;
	public GameObject block;
	
	public void NextScene(){
		try {
			Debug.Log("ChangeScene");
			block.GetComponent<Renderer>().material.color = Color.green;
        	SceneManager.LoadScene(NextLevel , LoadSceneMode.Single);
		}
		catch (Exception e) {
			Debug.Log("Error");
			block.GetComponent<Renderer>().material.color = Color.yellow;
		} 
		
	}
}
