using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastTest : MonoBehaviour {
	public LayerMask layerMask;
	void Update(){
		RaycastHit hit;
		Ray ray = new Ray(transform.position, Vector3.up);
		Debug.DrawRay(transform.position, Vector3.up*10);
		if (Physics.Raycast (ray, out hit, 10, layerMask)) {
			if(hit.transform.GetComponent<Image>().mainTexture == this.GetComponent<Image>().mainTexture){
				this.GetComponent<Image>().color = Color.blue;
				hit.transform.gameObject.SetActive(false);
				this.GetComponent<Image>().enabled = true;
			}	
		} 
	}
}


