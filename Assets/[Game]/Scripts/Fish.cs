using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float _speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;

    public Score score;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FishSwim();
        
    }

    private void FixedUpdate()
    {
        FishRotation();
    }
    private void FishSwim()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.zero;
            _rb.velocity = new Vector2(_rb.velocity.x, _speed);
        }
    }
    private void FishRotation()
    {
        if (_rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (_rb.velocity.y < -2.5f)
        {
            if (angle > minAngle)
            {
                angle = angle - 2;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            score.Scored();
        }
    }

}
