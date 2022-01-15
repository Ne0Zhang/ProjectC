using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove : MonoBehaviour
{
    public bool left = false;
    public float distance = 1f;
    public float waitSec;
    private float MAX, MIN;

    private bool PAUSE = false;

    public float speed = 2;
    private bool pause = false;
    float one;

    void Start()
    {
        if (left) {
            MAX = transform.position.x;
            MIN = transform.position.x - distance;
            one = -1;
        } else {
            MAX = transform.position.x + distance;
            MIN = transform.position.x;
            one = 1;
        }
        Debug.Log("***Current: " + transform.position.x + "\nMAX: " + MAX);
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (!PAUSE){
            if (!pause) {
                transform.Translate((one * Vector3.right) * speed * Time.deltaTime);
                if (transform.position.x > MAX || transform.position.x < MIN)
                    StartCoroutine(coroutineA(waitSec));
            }
        }
    }   

    IEnumerator coroutineA (float seconds) {
        pause = !pause;
        Debug.Log("coroutineA created: " + seconds);
        yield return new WaitForSeconds(seconds);
        Debug.Log("coroutineA finished");
        one *= -1;
        pause = !pause;
    }

    void OnTriggerEnter(Collider other) {
        if (!(other.gameObject.CompareTag("Player")))
            return;
        // Debug.Log("Is Player");
        PAUSE = true;
    }

    void OnTriggerExit(Collider other) {
        PAUSE = false;
    }
}
