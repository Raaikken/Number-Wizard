using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
	// Variables
	[SerializeField] int min = 1;
	[SerializeField] int max = 1000;
	[SerializeField] TextMeshProUGUI guessText;

	// Internal Variables
	int guess = 0;

	// Debug


	// Start is called before the first frame update
	void Start() {
		max += 1;
        Random.InitState(System.DateTime.Now.Minute + System.DateTime.Now.Second);
		guess = Random.Range((max / 2) - 100, (max / 2) + 100);
		guessText.text = guess.ToString();
	}
	
	public void Higher() {
		min = guess;
		NextGuess();
	}

	public void Lower() {
		max = guess + 1;
		NextGuess();
	}

	void NextGuess() {
		guess = Random.Range(min, max);
		guessText.text = guess.ToString();
	}
}
