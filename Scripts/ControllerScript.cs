using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler 
{

	//Touch Screen
	public void OnPointerDown(PointerEventData data)
	{
		if (gameObject.name == "Left") 
		{
			Debug.Log ("Touching Left");
		}
		if (gameObject.name == "Right") 
		{
			Debug.Log ("Touching Right");
		}
	}

	//Stop Touching Screen
	public void OnPointerUp(PointerEventData data)
	{
		Debug.Log ("Realease Screen");
	}
}
