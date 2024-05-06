using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectResetScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Reset player position
            other.transform.position = new Vector3(-24.05f, 21.75f, -1);
        }
    }
}
