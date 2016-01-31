using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuInput : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Submit")) {

			SceneManager.LoadScene ("Level", LoadSceneMode.Single);

		}
	
	}

}
