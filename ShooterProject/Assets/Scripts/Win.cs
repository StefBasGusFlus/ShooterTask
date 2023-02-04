using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
	private int _neededScore;
	public static int Score;

	[SerializeField] private Text scoreText;

	private void Start()
    {
		Score = 0;
		_neededScore = PlayerPrefs.GetInt("Count");
    }

	private void Update()
	{
		scoreText.text = Score.ToString();

		if (Score == _neededScore)
			StartCoroutine(TransitionScene());
	}

	private IEnumerator TransitionScene()
    {
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene(2);
	}
}
