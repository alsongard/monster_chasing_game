using UnityEngine;

public class enemyScripts : MonoBehaviour
{
    public float speed;

    public Rigidbody2D myBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        speed = 7f;
        myBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.linearVelocity = new Vector2(speed, myBody.linearVelocity.y);
    }
}
