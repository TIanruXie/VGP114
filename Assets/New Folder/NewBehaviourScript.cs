using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 5f;
    private Vector2 targetpostion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SetTargetPosition();
        }
        Move();
    }
    void SetTargetPosition()
    {
        targetpostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void Move()
    {
        Vector2 direction = new Vector2(targetpostion.x = transform.position.x, targetpostion.y = transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetpostion, Speed*Time.deltaTime);
    }
}

