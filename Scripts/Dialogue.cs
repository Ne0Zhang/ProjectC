using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public string message1;
    public Image DialogueBox;
    public Text Text;
    private bool enter = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enter)
            if (Input.GetKeyDown(KeyCode.F))
                DialogueBox.enabled = !DialogueBox.enabled;
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
            enter = !enter;
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player"))
            enter = !enter;
    }
}
