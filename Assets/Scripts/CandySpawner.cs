using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] candySpawner;
    [SerializeField] float spawnInterval;
     private readonly int randPosition = 8;

    void Start()
    {
        StartSpawningCandies();
    }

  
 
    private void CreateCandies()
    {
        int randCandy = Random.Range(0,candySpawner.Length);
        float candyPos = Random.Range(-randPosition, randPosition);
        Vector3 randPos =  new Vector3(candyPos, transform.position.y, transform.position.z);
        Instantiate(candySpawner[randCandy], randPos, transform.rotation);
        

    }

    IEnumerator SpawnCandies()
    {
       
        yield return new WaitForSeconds(2f);
           
        while (true)
        {
            CreateCandies();
            yield return new WaitForSeconds(spawnInterval);
        }

    }


    public void StartSpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }
}
