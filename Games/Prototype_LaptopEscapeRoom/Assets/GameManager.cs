using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject SetupCanvas, ComputerLogin, Win, Error;

	public InputField loginPasswordInstantiate;
	public InputField loginPassword;
	public Button submitInstantiation;
	public Button submitLoginPassword;

	public string loginPass;

	void Start(){
		submitInstantiation.onClick.AddListener(SetParameters);
        submitLoginPassword.onClick.AddListener(delegate {CheckIfCorrect(0); });
	}

	void Update(){
		if(submitLoginPassword.IsActive()){
			if(Input.GetKeyDown(KeyCode.Return)){
				CheckIfCorrect(0);
			}
		}
	}

	private void SetParameters(){
		if(loginPasswordInstantiate.text != ""){
			loginPass = loginPasswordInstantiate.text;
			SetupCanvas.SetActive(false);
			ComputerLogin.SetActive(true);
		}	
	}

	private void CheckIfCorrect(int whichCheck){
		switch (whichCheck){
			case 0:
				if(loginPassword.text == loginPass){
					OpenComputer();
				} else {
					loginPassword.text = "";
					if(!Error.active){
						Error.SetActive(true);
					} else {
						Error.GetComponent<Text>().color = new Color(Random.Range(0.1f,1),Random.Range(0.1f,1),Random.Range(0.1f,1));
					}
				}
				break;
			default:
				print("Out of scope");
				break;
		}
	}

	private void OpenComputer(){
		Debug.Log("Open Computer");
		ComputerLogin.SetActive(false);
		Win.SetActive(true);
	}
}
