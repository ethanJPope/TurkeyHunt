using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer[] scoreThings;
    [SerializeField] private SpriteRenderer[] bullets;

    void Start()
    {
        PlayerPrefs.SetInt("TurkeyDead", 0);
        PlayerPrefs.SetInt("Score", 0);
    }

    void Update()
    {
        switch (PlayerPrefs.GetInt("Shots")) {
            case 0:
                bullets[0].enabled = false;
                bullets[1].enabled = false;
                bullets[2].enabled = false;
                break;
            case 1:
                bullets[0].enabled = true;
                bullets[1].enabled = false;
                bullets[2].enabled = false;
                break;
            case 2:
                bullets[0].enabled = true;
                bullets[1].enabled = true;
                bullets[2].enabled = false;
                break;
            case 3:
                bullets[0].enabled = true;
                bullets[1].enabled = true;
                bullets[2].enabled = true;
                break;
        }
        switch (PlayerPrefs.GetInt("Score")) {
            case 1:
                scoreThings[0].color = Color.red;
                break;
            case 2:
                scoreThings[1].color = Color.red;
                break;
            case 3:
                scoreThings[2].color = Color.red;
                break;
            case 4:
                scoreThings[3].color = Color.red;
                break;
            case 5:
                scoreThings[4].color = Color.red;
                break;
            case 6:
                scoreThings[5].color = Color.red;
                break;
            case 7:
                scoreThings[6].color = Color.red;
                break;
            case 8:
                scoreThings[7].color = Color.red;
                break;
            case 9:
                scoreThings[8].color = Color.red;
                break;
            case 10:
                scoreThings[9].color = Color.red;
                break;
            default :
                for (int i = 0; i < scoreThings.Length; i++)
                {
                    scoreThings[i].color = Color.white;
                }
                break;
        }
    }
}
