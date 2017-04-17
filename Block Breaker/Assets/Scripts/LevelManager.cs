using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log("Level load request for: " + name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest() {
		Debug.Log("I WANT TO QUIT");
		Application.Quit();
	}

	public void ReturnToMenu() {
		Debug.Log("Return to Menu");
		SceneManager.LoadScene("Start");
	}
}
