using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0.3f);
    }

}
