using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Remover : MonoBehaviour
{
	public Text gameOverText;
	public GameObject player;

	private int playerScore;

	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		{
			playerScore = player.GetComponent<PlayerControl> ().scoreCount;

			// set game over text
			gameOverText.text = "GAME OVER\nYou Scored " + playerScore.ToString() + "!";
			// ... destroy the player.
			Destroy (col.gameObject);
			// ... reload the level.
			StartCoroutine("ReloadGame");
		}
		else
		{
			// Destroy the enemy.
			Destroy (col.gameObject);	
		}
	}

	IEnumerator ReloadGame()
	{			
		// ... pause briefly
		yield return new WaitForSeconds(3);
		// ... and then reload the level.
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
