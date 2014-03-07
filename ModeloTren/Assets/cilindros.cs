using UnityEngine;
using System.Collections;

public class cilindros : MonoBehaviour {
	// Use this for initialization
	public void crear () {
		GameObject cilindromedio1, cilindromedio2;
		GameObject cilindrodelante1, cilindrodelante2;
		GameObject cilindrolateral1, cilindrolateral2;

		cilindromedio1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cilindromedio1.name = "Cilindromedio1";
		cilindromedio1.transform.position = new Vector3 (-0.2f,-0.6f,1.3f);
		cilindromedio1.transform.rotation = Quaternion.Euler (90, 0, 0);
		cilindromedio1.transform.localScale = new Vector3 (0.07f, 0.07f , 0.07f);
		cilindromedio2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cilindromedio2.name = "Cilindromedio2";
		cilindromedio2.transform.position = new Vector3 (0.2f,-0.6f,1.3f);
		cilindromedio2.transform.rotation = Quaternion.Euler (90, 0, 0);
		cilindromedio2.transform.localScale = new Vector3 (0.07f, 0.07f , 0.07f);
		cilindrodelante1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cilindrodelante1.name = "Cilindrodelante1";
		cilindrodelante1.transform.position = new Vector3 (-0.2f,-0.6f,1.37f);
		cilindrodelante1.transform.rotation = Quaternion.Euler (90, 0, 0);
		cilindrodelante1.transform.localScale = new Vector3 (0.12f, 0.015f , 0.12f);
		cilindrodelante2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cilindrodelante2.name = "Cilindrodelante2";
		cilindrodelante2.transform.position = new Vector3 (0.2f,-0.6f,1.37f);
		cilindrodelante2.transform.rotation = Quaternion.Euler (90, 0, 0);
		cilindrodelante2.transform.localScale = new Vector3 (0.12f, 0.015f , 0.12f);		
		cilindrolateral1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cilindrolateral1.name = "Cilindrolateral1";
		cilindrolateral1.transform.position = new Vector3 (-0.7f,-0.6f,1);
		cilindrolateral1.transform.rotation = Quaternion.Euler (90, 0, 0);
		cilindrolateral1.transform.localScale = new Vector3 (0.25f, 0.25f , 0.25f);
		cilindrolateral2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cilindrolateral2.name = "Cilindrolateral2";
		cilindrolateral2.transform.position = new Vector3 (0.7f,-0.6f,1);
		cilindrolateral2.transform.rotation = Quaternion.Euler (90, 0, 0);
		cilindrolateral2.transform.localScale = new Vector3 (0.25f, 0.25f , 0.25f);
	}

}
