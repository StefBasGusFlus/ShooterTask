using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void GoPlay() => SceneManager.LoadScene(0);
}
