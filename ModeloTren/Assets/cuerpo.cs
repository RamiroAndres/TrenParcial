using UnityEngine;
using System.Collections;

public class  cuerpo : MonoBehaviour {

	// Use this for initialization
	public void crear () {
		GameObject cabina, cube, cuerpo, techo;
		cabina = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cabina.name = "Cabina";
		cabina.transform.position = new Vector3(0,0.1f,-1.6f);
		cabina.transform.localScale = new Vector3 (1.2f, 1.7f, 1);
		cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.name = "Cubo";
		cube.transform.position = new Vector3 (0, -0.6f, 0.07f);
		cube.transform.localScale = new Vector3 (1.2f, 0.2f, 2.4f);
		cuerpo = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cuerpo.name="Cuerpo";
		cuerpo.transform.position = new Vector3 (0,0,0);		
		cuerpo.transform.rotation = Quaternion.Euler (90, 0, 0);
		cuerpo.transform.localScale = new Vector3 (1, 1.1f, 1);
		techo = GameObject.CreatePrimitive (PrimitiveType.Cube);
		techo.name = "Techo";
		techo.transform.position = new Vector3 (0, 1, -1.6f);
		techo.transform.localScale = new Vector3 (1.4f,0.2f,1.2f);

	}
}
