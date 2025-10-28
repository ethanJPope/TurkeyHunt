using UnityEngine;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    [SerializeField] private Text levelText;
    void Start()
    {
        PlayerPrefs.SetInt("Level", 1);
    }

    void Update()
    {
        levelText.text = "R= " + PlayerPrefs.GetInt("Level").ToString();
        switch (PlayerPrefs.GetInt("Level"))
        {
            case 1:
                PlayerPrefs.SetInt("TurkeySpeed", 3);
                break;
            case 2:
                PlayerPrefs.SetInt("TurkeySpeed", 5);
                break;
            case 3:
                PlayerPrefs.SetInt("TurkeySpeed", 7);
                break;
            case 4:
                PlayerPrefs.SetInt("TurkeySpeed", 8);
                break;
            case 5:
                PlayerPrefs.SetInt("TurkeySpeed", 10);
                break;
            case 6:
                UnityEngine.SceneManagement.SceneManager.LoadScene("WinScene");
                break;

        }
    }
}
