using UnityEngine;
using System.Collections;

public class setarrival : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
	
	}*/
	
	// Update is called once per frame
	/*void Update () {
	
	}*/
	public void OnTriggerenter(Collider other){
		GameObject.Find ("Car").SendMessage ("Finnish");
	
	}
}
