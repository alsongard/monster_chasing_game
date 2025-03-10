using UnityEngine;

public class camerafollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;

    private float min_X, max_X;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //intialize variables   
        player  = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        min_X = -51.75184f;
        max_X = 56.750f;
        tempPos = transform.position;
        tempPos.x = player.position.x;


        if (tempPos.x >= max_X)
        {
            tempPos.x = max_X;

        }
        else if (tempPos.x <= min_X)
        {
            tempPos.x = min_X;
        }


        transform.position = tempPos;
        
    }
}
