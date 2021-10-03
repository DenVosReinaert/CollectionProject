using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float lives = 3f;
    public GameObject bullet;


    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !bullet.activeInHierarchy)
        {
            bullet.transform.position = this.transform.position;
            bullet.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0) * speed;
    }
}
