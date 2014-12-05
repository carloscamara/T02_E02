using UnityEngine;
using System.Collections;

//Clase PuertasAscenso
public class PuertasAscensor : MonoBehaviour {
	//En el caso de chocar con el collaider
	void OnTriggerEnter(Collider collider)
	{//En el caso de que el colloder que choque sea  el personsaje y ademas la propiedad boton de la clase inventario esta true,llamamos a la animacion AbrirAscensor .
		if (collider.name == "Player" && collider.gameObject.GetComponent<Inventario>().boton==true)
		{
			this.GetComponent<Animation>().Play("AbrirAscensor");
		}
	}
	//En el caso de salir del collaider
	void OnTriggerExit(Collider collider)
	{//En el caso de que el colloder que choque sea  el personsaje y ademas la propiedad boton de la clase inventario esta true,llamamos a la animacion CerrarAscensor .
		if (collider.name == "Player" && collider.gameObject.GetComponent<Inventario>().boton==true)
		{
			this.GetComponent<Animation>().Play("CerrarAscensor");
		}

		}
	}

