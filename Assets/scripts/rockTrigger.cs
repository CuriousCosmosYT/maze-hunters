using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockTrigger : MonoBehaviour
{
    public bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        trigger = true;
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        trigger = false;
    }
}
