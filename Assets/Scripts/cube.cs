using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	Rigidbody ball; 

	Vector3 vec = new Vector3(0,1,1); 

	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		ball.angularDrag = 12; 
		ball.AddForce(Vector3.forward * 10f);
	}
}
