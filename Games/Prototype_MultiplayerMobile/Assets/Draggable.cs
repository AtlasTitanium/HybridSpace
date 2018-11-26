using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Draggable : MonoBehaviour, IDragHandler, IEndDragHandler {
	private Vector3 hitPoint;
	public LayerMask layerMask;
	public void OnDrag(PointerEventData eventData){
		this.GetComponent<Collider>().enabled = false;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 50f, layerMask)) 
		{
			hitPoint = hit.point;
			transform.position = new Vector3(hit.point.x,hit.point.y,transform.position.z);			
		}    
	}

	public void OnEndDrag(PointerEventData eventData){
		this.GetComponent<Collider>().enabled = true;
		transform.position = hitPoint;
	}
}
