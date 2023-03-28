using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmAI : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerPos;
    public float SpaceBetween = 1.5f;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);

        //Here, the particle following the player.
        transform.position = Vector3.MoveTowards(transform.position, playerPos, 5f * Time.deltaTime);
    }
}
