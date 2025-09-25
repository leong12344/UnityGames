using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos; 
    AudioSource audioSource;

    void Start()
    {
        Application.targetFrameRate = 60;
        audioSource = GetComponent<AudioSource>(); // get the AudioSource component
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = (Vector2)Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = (Vector2)Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            this.speed = swipeLength / 500.0f;

            // Play sound if audio source exists
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }

        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        this.speed *= 0.98f; // gradually slow down
    }
}
