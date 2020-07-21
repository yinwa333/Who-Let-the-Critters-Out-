using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyMoveVertical : MonoBehaviour
{

    public int EnemySpeed;
    public int YMoveDirection;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0, YMoveDirection));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, YMoveDirection) * EnemySpeed;
        if (hit.distance < 1.0f)
        {
            Flip();
        }
    }

    void Flip()
    {
        if (YMoveDirection < 0)
        {
            YMoveDirection = 1;
        }
        else
        {
            YMoveDirection = -1;
        }
    }
}
