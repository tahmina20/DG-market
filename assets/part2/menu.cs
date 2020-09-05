using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public void GoToMainMenu()
	{
		Application.LoadLevel ("loading");
	}

	public void GoToARCamera()
	{
		Application.LoadLevel ("level01");

	}

	public void GoTOAbout()
	{
		Application.LoadLevel ("about");
	}

	public void ExitApplication()
	{
		Application.Quit ();
	}
}