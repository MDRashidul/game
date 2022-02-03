using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	
	public int score;
	
	
	Text text;
	
	void Start()
	{
		text = GetComponent <Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		score = Dot.score;
		text.text = "Score: " + score;
		
		
	}
	
	
	//END
}