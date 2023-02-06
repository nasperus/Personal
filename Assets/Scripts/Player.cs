using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] [Range(0, 20)] int moveSpeed;
    private int moveX = 8;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right* horizontal * moveSpeed * Time.deltaTime;
        float movePos = Mathf.Clamp(transform.position.x, -moveX, moveX);
        transform.position = new Vector3(movePos, transform.position.y, transform.position.z);
    }


}
