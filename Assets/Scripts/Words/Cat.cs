using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private float speed = 1.0f;
    private Vector3 goal;
    [SerializeField]
    private Sprite sitting;
    [SerializeField]
    private Sprite walking;
    float timeLeft = 5;

    void Start()
    {
        goal = new Vector3(-3, 0, 0);
    }

    void LateUpdate()
    {
        Vector2 direction = goal - this.transform.position;

        if (direction.magnitude > 0.1)
        {
            this.transform.Translate(direction.normalized * speed * Time.deltaTime);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = walking;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sitting;
           
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                SwitchDirection();
            }            
        }       
    }

    void SwitchDirection()
    {
        if (goal == new Vector3(-3, 0, 0))
        {
            timeLeft = 5;
            goal = new Vector3(2, 0, 0);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = !this.gameObject.GetComponent<SpriteRenderer>().flipX;
        }
        else
        {
            timeLeft = 5;
            goal = new Vector3(-3, 0, 0);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = !this.gameObject.GetComponent<SpriteRenderer>().flipX;
        }
    }
}
