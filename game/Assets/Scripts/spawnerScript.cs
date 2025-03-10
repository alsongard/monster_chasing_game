using System.Collections;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField]
    private Transform leftPos, rightPos;

    private GameObject spawnedMonster;

    private int randomIndex;
    private int randomSide;

    void Start()
    {
        StartCoroutine(SpawnMonsterFunct());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnMonsterFunct()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
            randomIndex = Random.Range(0, monsterReference.Length); // length == 3 0, 1, 2, 3(inclusive)
            randomSide = Random.Range(0,2); // guessing Range(inclusive, exclusive) for integers // in float both minimum and max are included

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            if (randomSide == 1)
            {
                //left side
                Debug.Log("monster spawned in left side");
                spawnedMonster.transform.position = leftPos.position;

                // take speed varaible from enemyScripts class and assign speed to spawnedMonster
                spawnedMonster.GetComponent<enemyScripts>().speed = Random.Range(4, 7);
            }
            else
            {
                Debug.Log("monster spawned in right side");

                // monster spawned in right side
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<enemyScripts>().speed = -Random.Range(4, 9);

                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }
}
