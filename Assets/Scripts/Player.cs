using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] [Range(0,20)] int moveSpeed;
    private readonly int xAxis = 8;
    public  bool canMove = true;
   
  

    private void Update()
    {
       
            Move();
        
        
    }


    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * moveX * moveSpeed * Time.deltaTime;
        float moveXpos = Mathf.Clamp(transform.position.x, -xAxis, xAxis);
        transform.position = new Vector3(moveXpos, transform.position.y, transform.position.z);
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }


}
