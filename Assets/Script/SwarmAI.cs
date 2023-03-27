using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmAI : MonoBehaviour
{
    public Transform player;
    public float SpaceBetween = 1.5f;

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) >= SpaceBetween)
        {
            Vector3 direction = player.position - transform.position;
            transform.Translate(direction * Time.deltaTime);
        }
    }
}
