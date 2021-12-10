using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopStarSelf : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject starObj = GameObject.FindGameObjectWithTag("stars");
        Physics.IgnoreCollision(starObj.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stars")
        {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }*/
}
