using UnityEngine;
using System.Collections;

public class ruedas : MonoBehaviour {

	// Use this for initialization
	public void crear () {
		GameObject rueda1, rueda2, rueda3, rueda4, rueda5, rueda6;
		rueda1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		rueda1.name = "Rueda1";
		rueda1.transform.position = new Vector3 (-0.7f, -0.6f, 0.3f);
		rueda1.transform.rotation = Quaternion.Euler (0, 0, 90);
		rueda1.transform.localScale = new Vector3 (0.8f, 0.08f , 0.8f);
		rueda2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		rueda2.name = "Rueda2";
		rueda2.transform.position = new Vector3(0.7f, -0.6f, 0.3f);
		rueda2.transform.rotation = Quaternion.Euler (0, 0, 90);
		rueda2.transform.localScale = new Vector3 (0.8f, 0.08f , 0.8f);
		rueda3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		rueda3.name = "Rueda3";
		rueda3.transform.position = new Vector3 (-0.7f, -0.6f, -0.7f);
		rueda3.transform.rotation = Quaternion.Euler (0, 0, 90);
		rueda3.transform.localScale = new Vector3 (0.8f, 0.08f , 0.8f);
		rueda4 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		rueda4.name = "Rueda4";
		rueda4.transform.position = new Vector3 (0.7f, -0.6f, -0.7f);
		rueda4.transform.rotation = Quaternion.Euler (0, 0, 90);
		rueda4.transform.localScale = new Vector3 (0.8f, 0.08f , 0.8f);
		rueda5= GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		rueda5.name = "Rueda5";
		rueda5.transform.position = new Vector3 (0.7f, -0.6f, -1.7f);
		rueda5.transform.rotation = Quaternion.Euler (0, 0, 90);
		rueda5.transform.localScale = new Vector3 (0.8f, 0.08f , 0.8f);
		rueda6 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		rueda6.name = "Rueda6";
		rueda6.transform.position = new Vector3 (-0.7f, -0.6f, -1.7f);
		rueda6.transform.rotation = Quaternion.Euler (0, 0, 90);
		rueda6.transform.localScale = new Vector3 (0.8f, 0.08f , 0.8f);
	}

}
