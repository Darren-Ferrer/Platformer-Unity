using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDeath : MonoBehaviour
{
    function OnTriggerEnter (collision : Collider)
    {
        print("Triggered: " + collision.tag);
        if(collision.gameObject.tag == "Player")
        {
            Application.LoadLevel("Level 1"); //try integer value to verify
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
