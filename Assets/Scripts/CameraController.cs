﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public float PlayerCameraDistance{ get; set;}
	public Transform cameraTarget;
	Camera playerCamera;
	float zoomSpeed=25f;

	// Use this for initialization
	void Start () {
		PlayerCameraDistance = 10f;
		playerCamera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw("Mouse ScrollWheel")!=0){
			
		}
		transform.position = new Vector3 (cameraTarget.position.x,cameraTarget.position.y+PlayerCameraDistance,cameraTarget.position.z+PlayerCameraDistance);
	}
}
