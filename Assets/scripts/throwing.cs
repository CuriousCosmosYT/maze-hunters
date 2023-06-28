using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwing : MonoBehaviour
{
    public Transform throwPoint;
    public GameObject squarePrefab;
    public float throwForce = 20f;
    public float cooldown = 0.4f;
    private float nextThrowTime = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(Time.time > nextThrowTime)
            {
                Shoot();
            }
        }
    }
    void Shoot()
    {
        GameObject square = Instantiate(squarePrefab, throwPoint.position, throwPoint.rotation);
        Rigidbody2D rb = square.GetComponent<Rigidbody2D>();
        rb.AddForce(throwPoint.up * throwForce, ForceMode2D.Impulse);
        nextThrowTime = Time.time + cooldown;
    }
}
