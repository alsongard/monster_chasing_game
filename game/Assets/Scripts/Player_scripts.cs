using UnityEngine;

public class Player_scripts : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;
    // public float maxVelocity = 22f;/
    // 

    /*
        rather that just using GetComponent to acquire/access every component in Unity such as 
        RigidBody2D, boxCollider2D, Animator, Audio, we use private variables which are memory 
        efficient and can be stored/cached.
        If we were to use GetComponent, this will be troubling as it will result to 
        the components being fetched in every frame which is slow

        hence we use 
        SYNTAX : ``private UnitComponentName variableName;``


        Now to GetTheComponent we use: 
        ``privateVariableName = GetComponent<ComponentName>()``
    */

    private float movementX;

    [SerializeField]
    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string  WALK_ANIMATION = "walk";

    private bool isGrounded = true;

    private string GROUND_TAG = "Ground";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyBoard();   
        AnimatePlayer();
    }

    void FixedUpdate()
    {
        PlayerJump();   
    }

    public void PlayerMoveKeyBoard()
    {
        // get keyboard movement for horizontal keys which are A & D
        //  GetAxisRaw : this gets value from 0 to 1 or from 0 to -1 which is faster
        // GetAxis: moves from 0-0.1.., 0.2.. until 1 or from 0 to -0.1.., -0.2.. upto -1 which is slower

        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }

    public void AnimatePlayer()
    {
        if (movementX  > 0)
        {
            // moving to right side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;

        }
        else if (movementX < 0)
        {
            // moving to the left side
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true; // change face

        }
        else 
        {
            // remain idle
            anim.SetBool(WALK_ANIMATION, false);
            
        }
    }
    public void PlayerJump()
    {

       if( Input.GetButtonDown("Jump") && isGrounded)
       {
            isGrounded = false;
            // Debug.Log("character is jumping");
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
       }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(GROUND_TAG))
        {
            Debug.Log("Player landed on Ground");
            isGrounded = true;
        }
    }



}
