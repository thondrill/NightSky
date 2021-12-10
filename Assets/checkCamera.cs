using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkCamera : MonoBehaviour
{
    public Transform target;
    public Camera cam;
    public GameObject[] allStars;
    int starCount;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        starCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = cam.WorldToViewportPoint(target.position);
        bool onScreen = screenPos.x > 0f && screenPos.x < Screen.width && screenPos.y > 0f && screenPos.y < Screen.height;
        foreach (GameObject star in allStars) {
            //if amount of stars off screen less than half array, reset
            Debug.Log("in for");
            if (!onScreen && starCount < allStars.Length/3)
            {
                Debug.Log("in if");
                starCount++;
            }
            else
            {
                SceneManager.LoadScene("test");
            }
        }
        
    }
}

