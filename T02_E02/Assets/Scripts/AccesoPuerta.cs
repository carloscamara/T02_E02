using UnityEngine;
using System.Collections;
//clase AccesoPuerta
public class AccesoPuerta : MonoBehaviour {

	//En el caso de chocar con el collaider
	void OnTriggerEnter(Collider collider)
	{
		//En el caso de que el colloder que choque sea  el personsaje y ademas la propiedad llave de la clase inventario esta true,llamamos a la animacion por defecto.
		if (collider.name == "Player" && collider.gameObject.GetComponent<Inventario>().llave==true)
		{
			this.GetComponent<Animation>().Play();
		}
	}
	//En el caso de salir del collaider
	void OnTriggerExit(Collider collider)
	{
		//En el caso de que el colloder que choque sea  el personsaje y ademas la propiedad llave de la clase inventario esta true,llamamos a la animacion CerrarPuerta
		if (collider.name == "Player" && collider.gameObject.GetComponent<Inventario>().llave==true)
		{
			this.GetComponent<Animation>().Play("CerrarPuerta");
		}

		}
	}

