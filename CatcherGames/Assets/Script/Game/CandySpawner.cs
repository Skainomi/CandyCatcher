using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : GameManager
{
    // Start is called before the first frame update
    float randomPos;
    public float spawnInterval;
    bool go = true;
    void Start()
    {
        startSpawnCandy();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.MAID.gameOver)
            StopCoroutine("spawn");
    }

    void spawnCandy()
    {
        randomPos = Random.Range(-GameObject.Find("Player/Player").GetComponent<PlayerControl>().maxDistance, GameObject.Find("Player/Player").GetComponent<PlayerControl>().maxDistance);
        Vector3 randPos = new Vector3(randomPos, transform.position.y, transform.position.z);
        Instantiate(candy, randPos, Quaternion.identity);
    }
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            spawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void startSpawnCandy()
    {
        if(!GameManager.MAID.gameOver)
        {
            StartCoroutine("spawn");
        }
    }
}
