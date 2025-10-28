using UnityEngine;
using System.Collections;

public class TurkeySpawner : MonoBehaviour
{
    [SerializeField] private GameObject turkeyPrefab;
    [SerializeField] private float delay = 1f;


    void Update()
    {
        
        if (PlayerPrefs.GetInt("Score") <= 10)
        {
            if (PlayerPrefs.GetInt("TurkeyDead") == 1)
            {
                PlayerPrefs.SetInt("TurkeyDead", 0);
                StartCoroutine(SpawnAfterDelay());
            }
        }
        else
        {
            PlayerPrefs.SetInt("Score", 0);
            PlayerPrefs.SetInt("Skip", 0);
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
        }
    }

    private void Spawn() 
    {
        Vector3 pos = new Vector3(0, -2.5f, 1f);
        Instantiate(turkeyPrefab, pos, Quaternion.identity);
    }

    private IEnumerator SpawnAfterDelay() 
    {
        yield return new WaitForSeconds(delay);
        Spawn();
    }
}
