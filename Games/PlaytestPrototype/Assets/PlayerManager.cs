using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Team {Team1, Team2, Team3, Team4}
public class PlayerManager : MonoBehaviour {
	public Team currentTeam;
	public GUIStyle buttonStyle;
	void Start () {
		DontDestroyOnLoad(this);
	}

	void OnGUI(){
		buttonStyle = new GUIStyle();
		if(GUI.Button(new Rect(0,0,Screen.width,Screen.height/4), "Team 1", buttonStyle)){

		}
		if(GUI.Button(new Rect(0,Screen.height/4,Screen.width,Screen.height/4), "Team 2", buttonStyle)){

		}
		if(GUI.Button(new Rect(0,Screen.height/2,Screen.width,Screen.height/4), "Team 3", buttonStyle)){

		}
		if(GUI.Button(new Rect(0,(Screen.height-(Screen.height/4)),Screen.width,Screen.height/4), "Team 4", buttonStyle)){

		}
	}
}
