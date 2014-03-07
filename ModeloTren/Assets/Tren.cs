using UnityEngine;
using System.Collections;

public class Tren : MonoBehaviour {

	// Use this for initialization
	public void creacion () {
		cuerpo c = new cuerpo();
		ventanas v = new ventanas();
		ruedas r = new ruedas();
		chimeneas ch = new chimeneas();
		cilindros ci = new cilindros();
		c.crear ();
		v.crear ();
		r.crear ();
		ch.crear ();
		ci.crear ();
	}
}
