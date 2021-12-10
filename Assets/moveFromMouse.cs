using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFromMouse : MonoBehaviour
{
    Vector3 originalPos;
    Camera cam;
    Event currentEvent;

    Vector2 mousePos;
    Vector2 point;
    Vector3 target;

    float step;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        step = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //on trigger enter check if mouse is near the box collider of circle and if it is, send the object moving away from the cursor with Vector
        //attach an invisible game object to the mouse and give it a collider that scares the other circles away
    }
    
    void OnCollisionEnter(Collision starCollision)
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point = new Vector2();

        target = new Vector3(0.0f, 0.0f, 0.0f);
        point = new Vector3(mousePos.x, mousePos.y, 0.0f);

        if (starCollision.gameObject.tag == "stars")
        {
            //IT'S ONLY WORKING IF IT COLLIDES WITH A STAR OH!
            transform.position = Vector3.MoveTowards(originalPos, point, step * Time.deltaTime);
            //transform.position = new Vector2(Time.deltaTime * mousePos.x * -1, mousePos.y * -1 * Time.deltaTime);
        }
    }
}
