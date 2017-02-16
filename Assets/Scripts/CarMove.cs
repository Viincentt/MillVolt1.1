using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(1, 0, 0); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Translate(-1, 0, 0); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Rotate(0, -5, 0); }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Rotate(0, 5, 0); }
    }
}
