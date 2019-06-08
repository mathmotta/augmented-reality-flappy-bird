using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoAnda : MonoBehaviour
{
    public float XSpeed = 1;

    void Update()
    {
        MoveCano();
    }

    void MoveCano()
    {
        transform.position += new Vector3(Time.deltaTime * XSpeed, 0, 0);
    }
}
