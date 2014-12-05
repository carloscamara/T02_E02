using UnityEngine;
using System.Collections;
//Clase Pulsar
public class Pulsar : MonoBehaviour {
	//propiedades SerializeField,devido a que son privadas.
	[SerializeField]
	private Animation animacionPulsar;
	private GameObject ContenedorBoton;
	[SerializeField]
	private Animation animacionAscensor;
	private GameObject Ascensor;

	/*Al comenzar,almaceno en la propiedad animacionPulsar, los componentes de animacion que contiene ContenedorBoton ademas,en la propiedad animacionAscensor
	almaceno todos los componentes de animacion de ascensor*/
	void start()
	{
		animacionPulsar = ContenedorBoton.GetComponent<Animation> ();
		animacionAscensor = Ascensor.GetComponent<Animation> ();
	}
	//En el caso de chocar con el collaider
	void OnTriggerEnter(Collider collider)
	{
		/*si el personaje choca con el collaider de boton, entonces ponemos a true la propiedad boton de la clase inventario
		 llamamos a la animacion de Alpulsar del boton  y a la animacion del ascensor BajarAscensor  */
		if (collider.name == "Player") {
			collider.gameObject.GetComponent<Inventario>().boton = true;
			animacionPulsar.Play("AlPulsar");
			animacionAscensor.Play("BajarAscensor");

		}
	}
	//En el caso de salir del collaider
	void OnTriggerExit(Collider collider)
	{
		//En el caso de que el collaider con el que choca sea el jugador,llamamos a la animacion Retorno
		if (collider.name == "Player") {
			animacionPulsar.Play("Retorno");

		}
	}
	//funcion, para que se ejecute primero la animacion Alpulsar del boton y depues se ejecute la animacion de subirAscensor.
	void Tiempo(){
		animacionPulsar.Play("AlPulsar");
		animacionAscensor.Play("SubirAscensor");

	}
}
