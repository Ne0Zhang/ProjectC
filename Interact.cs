using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject SpeechBubble;
    // Start is called before the first frame update
    void Start()
    {
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (!(other.gameObject.CompareTag("NPC")))
            return;
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = true;
    }
    void OnTriggerExit(Collider other) {
        SpeechBubble.GetComponent<SpriteRenderer>().enabled = false;
    }
}
