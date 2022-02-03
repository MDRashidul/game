using UnityEngine;
using System.Collections;

public class Dot : MonoBehaviour {
	public int scoreValue = 1;
	public static int score;
	
	
	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "Player") {
			Destroy (gameObject);	
			score += scoreValue;
			
		}
	}
}