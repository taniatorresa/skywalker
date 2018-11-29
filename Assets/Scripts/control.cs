using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class control : MonoBehaviour {
	public void CambiarEscena(string nombre)
	{
		print ("Cambiando la escena...");
		SceneManager.LoadScene (nombre);
	}

	void Update()
	{
		print ("Saliendo del juego");

	}

	public void Salir(string salir)
	{
		print ("Saliendo del juego");
		Application.Quit();
	}
}