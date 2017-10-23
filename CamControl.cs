using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour 
{
	public float Speed;
	float pos = 0.5f;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		//forward 
		if (Input.GetKey (KeyCode.W)) 
		{
			Camera.main.transform.position += Camera.main.transform.forward * pos * Speed;
		}

		//Back
		if (Input.GetKey (KeyCode.S)) 
		{
			Camera.main.transform.position -= Camera.main.transform.forward * pos * Speed;
		}

		//Left 
		if(Input.GetKey(KeyCode.A))
		{
			Camera.main.transform.position -= Camera.main.transform.right * pos * Speed;
		}

		//Right
		if(Input.GetKey(KeyCode.D))
		{
			Camera.main.transform.position += Camera.main.transform.right * pos * Speed;
		}

		//Up
		if(Input.GetKey(KeyCode.Q))
		{
			Camera.main.transform.position += Camera.main.transform.up * pos * Speed;
		}

		//Down
		if(Input.GetKey(KeyCode.E))
		{
			Camera.main.transform.position -= Camera.main.transform.up * pos * Speed;
		}


		//Rotations
		//Left 
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			Camera.main.transform.Rotate (0,-1, 0, Space.World);
		}

		//Right
		if(Input.GetKey(KeyCode.RightArrow))
		{
			Camera.main.transform.Rotate (0,1, 0, Space.World);
		}

		//Up
		if(Input.GetKey(KeyCode.UpArrow))
		{
			Camera.main.transform.Rotate (-1,0, -0, Space.World);
		}

		//Down
		if(Input.GetKey(KeyCode.DownArrow))
		{
			Camera.main.transform.Rotate (1,0, 0, Space.World);
		}

	}
}