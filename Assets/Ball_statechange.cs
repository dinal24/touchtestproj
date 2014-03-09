using UnityEngine;
using System.Collections;


public class Ball_statechange : MonoBehaviour {
	float distance = 5 ;
	string msg1 = "....." ;
	string msg2 = "....." ;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
		{	/*
			
			*/Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    
    		Vector3 point = ray.origin + (ray.direction * distance);    
    		msg1 = point.ToString();
			msg2 = Input.mousePosition.ToString();
						
			/*
			Vector2 fingerPos =  Input.GetTouch(0).position;
			Vector3 pos = fingerPos;
			pos.z = 8;
    		Vector3 realWorldPos = Camera.main.ScreenToWorldPoint(pos);
			msg1 = pos.ToString();
			msg2 = realWorldPos.ToString();
			
			
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);    
    		Vector3 point = ray.origin + (ray.direction * distance);
			*/
			
			
			
			/*
    		
			transform.position = fingerPos;
			Vector3 pos = fingerPos;
			pos.z = 8;
			Vector3 realWorldPos = Camera.main.ScreenToWorldPoint(pos);
			Debug.Log("in!");
			rigidbody.AddForce(Vector3.up * 25);
			*/
			
			
		}
	}
	void OnGUI ()
{
        GUI.Label(new Rect(Screen.width * 0.5f - 50f, Screen.height * 0.5f - 10f, 100f, 20f),msg1 );
		GUI.Label(new Rect(Screen.width * 0.5f - 50f, Screen.height * 0.45f - 10f, 100f, 20f),msg2 );
   
}
	
}
