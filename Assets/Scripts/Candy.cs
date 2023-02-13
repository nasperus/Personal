using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.IncrementeScore();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Finish")
        {
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
        }
       
    }

}
