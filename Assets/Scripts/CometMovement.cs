using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometMovement : MonoBehaviour
{

    [SerializeField]
    Vector3 velocity = new Vector3(0, -2, 0);

    void Update()
    {
        transform.position += velocity * Time.deltaTime;       
    }
}
