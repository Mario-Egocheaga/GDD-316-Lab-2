using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyHutGen : MonoBehaviour
{
    public GameObject fenceSide;

    int Length = 1;
    int Width = 3;
    int Depth = 5;
    float Height = 4;
    float postWidth = 0.1f;
    float Separation = 3;


    void Start()
    {

        InvokeRepeating("GenerateTile", .75f, .75f);
    }

    void GenerateTile()
    {
        var fenceParent = new GameObject("Hut")
        {
            transform =
            {
                parent = transform
               
            }
        };
        Vector3 newPos = new Vector3(Random.Range(90, -10), 0, Random.Range(90, -10));

        for (var i = 0; i < Length; i++)
        {
            for (var j = 0; j < Width; j++)
            {
                if (j == 0)
                {
                    var position = new Vector3(newPos.x + i * Separation, newPos.y + 1, newPos.z + j);
                    var post = Instantiate(fenceSide, position, Quaternion.identity, fenceSide.transform);
                    post.transform.localScale = new Vector3(postWidth * 10f, Height, (float)Depth / 10.0f);
                    post.transform.Rotate(0f, 90f, 0f, Space.Self);
                }
                else if (j == Width - 1)
                {
                    var position = new Vector3(newPos.x + i * Separation, newPos.y + 1, newPos.z + j + 3f);
                    var post = Instantiate(fenceSide, position, Quaternion.identity, fenceSide.transform);
                    post.transform.localScale = new Vector3(postWidth * 10f, Height, (float)Depth / 10.0f);
                    post.transform.Rotate(0f, 90f, 0f, Space.Self);
                }
                else
                {
                    var position = new Vector3(newPos.x + i + 3f * Length, newPos.y + 1, newPos.z + j);
                    var post = Instantiate(fenceSide, position, Quaternion.identity, fenceSide.transform);
                    post.transform.localScale = new Vector3(postWidth * 10f, Height + .5f, (float)Depth / 10.0f);
                }
            }
        }
    }

}
