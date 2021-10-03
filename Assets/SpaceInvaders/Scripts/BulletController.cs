using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.transform.parent.name != "EventSystem")
        collision.gameObject.SetActive(false);

        this.gameObject.SetActive(false);
    }
}
