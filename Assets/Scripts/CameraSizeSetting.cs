using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSizeSetting : MonoBehaviour {

    private float cameraSize;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        cameraSize = Screen.height / 2;

        Camera.main.orthographicSize = cameraSize;
	}
}
