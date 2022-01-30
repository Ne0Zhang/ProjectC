using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Dialogue : MonoBehaviour
{
    // public string FilePath;
    // private string[] LINES;
    // int line = 0;
    public bool inRange = false;
    
    private Transform PressF;
    // Start is called before the first frame update
    void Start()
    {
        PressF = this.gameObject.transform.GetChild(0);
        PressF.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange) {
            if (Input.GetKeyDown(KeyCode.F)) {
                this.gameObject.GetComponent<NPCTalking>().PrintLine();
                this.gameObject.GetComponent<NPCTalking>().talk = true;
                inRange = !inRange;
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        if (!(other.gameObject.CompareTag("Player")))
            return;
        inRange = true;
        PressF.GetComponent<Renderer>().enabled = true;

    }

    void OnTriggerExit(Collider other) {
        if (!(other.gameObject.CompareTag("Player")))
            return;
        inRange = false;
        PressF.GetComponent<Renderer>().enabled = false;
    }
    // void OnTriggerEnter(Collider other) {
    //     if (!(other.gameObject.CompareTag("Player")))
    //         return;
    //     if(Input.GetKeyDown(KeyCode.F) && f) {
    //         talk = true;
    //         other.gameObject.GetComponent<PlayerMovement>().walk = false;
    //         f = !f;
    //     }
    //     
    // }

    // void OnTriggerExit(Collider other) {
    //     if (!(other.gameObject.CompareTag("Player")))
    //         return;
    //     talk = false;
    //     f = false;
    //     line = 0;
    // }
    
    // bool CheckFPress() {
    //     if(Input.GetKeyDown(KeyCode.F)) return true;
    //     else return false;
    // }
}
