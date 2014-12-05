using UnityEngine;
using System.Collections;
//clase Coger
public class Coger : MonoBehaviour {
	//En el caso de chocar con el collaider
	void OnTriggerEnter(Collider collider)
	{
			//si el personaje choca la llave,ponemos la variable llave, perteneciente a inventario a true.
			if (collider.name == "Player") {
			collider.gameObject.GetComponent<Inventario>().llave = true;
					//Eliminamos el objeto al que  collider.gameObject.GetComponent<Inventario>().llave = true;esta ligado el script
					Destroy (this.gameObject);
			}
	}
}
