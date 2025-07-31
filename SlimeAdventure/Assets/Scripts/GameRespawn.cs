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
            transform.position = new Vector3(11.44f, 1.817f, -6.942f);
        }
    }
}
