using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manu : MonoBehaviour {

	public void GoToMainMenu()
	{
		Application.LoadLevel ("loading");
	}

	public void GoToARCamera()
	{
		Application.LoadLevel ("road 3");

	}
		

	public void ExitApplication()
	{
		Application.Quit ();
	}
}