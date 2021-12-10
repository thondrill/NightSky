using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFromMouse : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //on trigger enter check if mouse is near the box collider of circle and if it is, send the object moving away from the cursor with Vector
        //attach an invisible game object to the mouse and give it a collider that scares the other circles away
    }
    
    void OnCollisionEnter(Collision starCollision)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (starCollision.gameObject.tag == "stars")
        {
            transform.position = new Vector2(Time.deltaTime * mousePos.x * -1, mousePos.y * -1 * Time.deltaTime);
        }
    }
}
