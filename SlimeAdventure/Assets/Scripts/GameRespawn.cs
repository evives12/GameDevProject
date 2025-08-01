using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameRespawn : MonoBehaviour
{
    public float threshold;

    private void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }
}
