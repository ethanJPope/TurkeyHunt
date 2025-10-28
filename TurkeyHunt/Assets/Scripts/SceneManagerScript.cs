using UnityEngine;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore");
        scoreText.text = "Score: " + finalScore.ToString();
    }
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void WinScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
    }

}
