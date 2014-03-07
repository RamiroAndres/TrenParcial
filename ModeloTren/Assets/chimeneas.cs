using UnityEngine;
using System.Collections;

public class chimeneas : MonoBehaviour {

	// Use this for initialization
	public void crear () {
		GameObject chimenea1, chimenea2, chimenea3;
		chimenea1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		chimenea1.name = "Chimenea1";
		chimenea1.transform.position = new Vector3 (0,0.6f,0.75f);
		chimenea1.transform.localScale = new Vector3 (0.3f,0.25f,0.3f);
		chimenea2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		chimenea2.name = "Chimenea2";
		chimenea2.transform.position = new Vector3 (0,0.45f,0);
		chimenea2.transform.localScale = new Vector3 (0.3f,0.25f,0.3f);
		chimenea3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		chimenea3.name = "Chimenea3";
		chimenea3.transform.position = new Vector3 (0,0.45f,-0.75f);
		chimenea3.transform.localScale = new Vector3 (0.3f,0.25f,0.3f);			
	}

}
