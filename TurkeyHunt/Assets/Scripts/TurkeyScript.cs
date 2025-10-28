using UnityEngine;
using UnityEngine.InputSystem;

public class TurkeyScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float distance = 10f;
    [SerializeField] private float speed = 5f;
    private Transform target;
    private Camera mainCamera;
    private float shots = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        PlayerPrefs.SetInt("Shots", 3);
        mainCamera = Camera.main;
        target = new GameObject().transform;
        rb = GetComponent<Rigidbody2D>();
        target.position = getRandomTargetPosition();

    }

    void Update()
    {
        //Debug.Log("Speeed " + speed);
        if (target == null)
        {
            return;
        }
        PlayerPrefs.SetInt("Shots", (int)shots);
        speed = (float)PlayerPrefs.GetInt("TurkeySpeed");
        Vector2 direction = target.position - transform.position;
        direction.Normalize();
        transform.position = Vector3.MoveTowards(this.transform.position, target.position, speed * Time.deltaTime);
        if (rb.position.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        if (Input.GetMouseButtonDown(0) && shots > 0)
        {
            shootTurkey();
        }
        
    }

    public Vector3 getRandomTargetPosition()
    {
        float xPos = Random.Range(-9, 9);
        return new Vector3(xPos, distance, 0);
    }

    public void shootTurkey()
    {
        Vector3 mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(mousePos, transform.position) < 1f && shots > 0)
        {
            shots -= 1;
            PlayerPrefs.SetInt("TurkeyDead", 1);
            Debug.Log("Hit!");
            int currentScore = PlayerPrefs.GetInt("Score");
            int currentSkip = PlayerPrefs.GetInt("Skip");
            PlayerPrefs.SetInt("Score", currentScore + currentSkip + 1);
            PlayerPrefs.SetInt("Skip", 0);
            PlayerPrefs.SetInt("FinalScore", PlayerPrefs.GetInt("FinalScore") + 1);
            rb.gravityScale = 1;
            Destroy(target.gameObject);
            target = null;
            //Destroy(gameObject, 2f);
        }
        else
        {
            Debug.Log("Missed!");
            shots -= 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Floor")) 
        {
            Destroy(gameObject);
        } else if (other.gameObject.CompareTag("Wall")) 
        {
            PlayerPrefs.SetInt("TurkeyDead", 1);
            int currentSkip = PlayerPrefs.GetInt("Skip");
            PlayerPrefs.SetInt("Skip", currentSkip + 1);
            Destroy(gameObject);

        }
    }

}
