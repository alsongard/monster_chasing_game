using UnityEngine;

public class invincibleWall : MonoBehaviour
{
    private string ENEMY_TAG = "enemy";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag(ENEMY_TAG) || collision.CompareTag("Player"))
        {
            // in the following we check the gameObject that collided with the wall & destroy
            Destroy(collision.gameObject);
        }

    }
}
