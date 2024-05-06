using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 targetPos;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + 1);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            targetPos = new Vector2(transform.position.x - 1, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            targetPos = new Vector2(transform.position.x + 1, transform.position.y);
        }
    }
}
