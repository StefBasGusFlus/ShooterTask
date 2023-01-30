using UnityEngine;
using UnityEngine.SceneManagement;

public class Launching : MonoBehaviour
{
    public void Play()
    {
        PlayerPrefs.SetInt("Count", CountGoalController.Count);
        SceneManager.LoadScene(1);
    }
}
