using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	Tren t = new Tren();
	void Start () {
		Debug.Log ("Llama al metodo creacion");
		t.creacion();
		
	}
}