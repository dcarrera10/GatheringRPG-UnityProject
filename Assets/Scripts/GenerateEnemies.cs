using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{

    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int randxPos;
    public int randzPos;
    public int enemyCount;

    // Starts spawning enemies
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    // Spawns in new enemies at a random location when under a certain number
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(randxPos-20, randxPos+20);
            zPos = Random.Range(randzPos-20, randzPos+20);
            Instantiate(theEnemy, new Vector3(xPos, 0.3f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
}
