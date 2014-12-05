using UnityEngine;
using System.Collections;

//Clase AbrirPuertOscura
public class AbrirPuertaOscura : MonoBehaviour {


	//Propiedades
	[SerializeField]
	private Animation animacionPuertaSecreta;
	private GameObject ContenedorPuertaSecreta;

	//Al comenzar
	void start()
	{
		animacionPuertaSecreta = ContenedorPuertaSecreta.GetComponent<Animation> ();
	}


	//En el caso de chocar con el trigger
	void OnTriggerEnter(Collider collider)
	{
		
		//En el caso de que el colloder que choque sea  el personsaje,llamamos a la animacion AbrirPuertaSecreta
		if (collider.name == "Player") {
			animacionPuertaSecreta.Play("AbrirPuertaSecreta");
			
		}
	}
	//En el caso de salir del collaider
	void OnTriggerExit(Collider collider)
	{
		//En el caso de que el colloder que choque sea el personaje,llamamos a la animacion CerrarPuertaSecreta
		if (collider.name == "Player") {
			animacionPuertaSecreta.Play("CerrarPuertaSecreta");
			
		}
	}


}

