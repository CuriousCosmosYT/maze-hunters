using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public Rigidbody2D rbr;
    playerMovement pms;
    [SerializeField] GameObject player;
    public float moveForce = 90;
    void Awake()
    {
        pms = player.GetComponent<playerMovement>();
        rbr.MovePosition(rbr.position + pms.movement * pms.moveSpeed * Time.fixedDeltaTime);
    }
    void FixedUpdate()
    {
        
    }
    void Start()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            rbr.AddForce(Vector2.right * moveForce, ForceMode2D.Impulse);
        }
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            rbr.AddForce(Vector2.left * moveForce, ForceMode2D.Impulse);
        }
        if(Input.GetAxisRaw("Vertical") > 0)
        {
            rbr.AddForce(Vector2.up * moveForce, ForceMode2D.Impulse);
        }
        if(Input.GetAxisRaw("Vertical") < 0)
        {
            rbr.AddForce(Vector2.down * moveForce, ForceMode2D.Impulse);
        }
        Destroy(gameObject, 1.5f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0.3f);
    }

}
