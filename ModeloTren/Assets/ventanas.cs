using UnityEngine;
using System.Collections;

public class ventanas : MonoBehaviour {

	// Use this for initialization
	public void crear () {
		GameObject ventanaIzquierda, ventanaDerecha;
		ventanaDerecha = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ventanaDerecha.name = "VentanaDerecha";
		ventanaDerecha.transform.position = new Vector3 (0.6f, 0.5f, -1.6f);
		ventanaDerecha.transform.localScale = new Vector3 (0.09f, 0.3f, 0.3f);
		ventanaIzquierda = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		ventanaIzquierda.name = "VentanaIzquierda";
		ventanaIzquierda.transform.position = new Vector3 (-0.6f, 0.5f, -1.6f);
		ventanaIzquierda.transform.localScale = new Vector3 (0.09f, 0.3f, 0.3f);
	}

}
