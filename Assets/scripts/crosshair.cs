using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{
    public Sprite largerCross;
    public Sprite smallerCross;
    public GameObject player;
    playerMovement pm;
    void Awake()
    {
        pm = player.GetComponent<playerMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        if(pm.moving == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = largerCross;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = smallerCross;
        }
    }
}
