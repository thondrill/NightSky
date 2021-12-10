using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkCamera : MonoBehaviour
{
    Renderer m_Renderer;
    public GameObject[] allStars;
    int starCount;
    // Start is called before the first frame update
    void Start()
    {
        starCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach (GameObject star in allStars) {
            //if amount of stars off screen less than half array, reset
            if (m_Renderer.isVisible && starCount < allStars.Length/3)
            {
                starCount++;
            }
            else
            {
                SceneManager.LoadScene("test");
            }
        }
        
    }
}

