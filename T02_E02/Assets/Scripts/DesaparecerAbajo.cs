using UnityEngine;
using System.Collections;
//clase DesaparecerAbajo
public class DesaparecerAbajo : MonoBehaviour {

	/// <summary>
	/// The posicion1.
	/// </summary>
	public Vector3 posicion1;
	public GameObject Cambio;
	public GameObject lugar;
	
	//Al comenzar la propiedad position1, va a tener los valores de la posicion lugar
	void Start () {
		posicion1 = lugar.transform.position;
	}
	//En el caso de chocar con el collaider
	void OnTriggerEnter(Collider collider)
	{
		//cambia la posicion
		Cambio.transform.position = posicion1;
		
	}
}
