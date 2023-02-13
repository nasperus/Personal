using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CandySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] candies;
    private readonly int candyPos = 8;
    public static CandySpawner instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        StartSwpawningCandies();
    }


    private void CreateCandies()
    {
        int randCandy = Random.Range(0, candies.Length);  
        float randomPos = Random.Range(-candyPos, candyPos);
        Vector3 pos = new Vector3(randomPos, transform.position.y, transform.position.z);
        Instantiate(candies[randCandy], pos, transform.rotation);
        
    }
   
    IEnumerator SpawnCandies ()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            CreateCandies();
            yield return new WaitForSeconds(1f);


        }
    }

    private void StartSwpawningCandies()
    {
        StartCoroutine("SpawnCandies");
    }

    public void StopSpawningCandies()
    {
        StopCoroutine("SpawnCandies");
    }

}
