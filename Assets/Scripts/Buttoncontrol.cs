using UnityEngine;
using System.Collections;

public class Buttoncontrol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void StartGame()
	{
		Application.LoadLevel ("Scene1");
	}
	public void RestartGame()
	{
		Application.LoadLevel ("Scene1");
		Dot.score = 0;
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
