using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

/*
This script will be responsible for the dialogue and talking.
*/

public class NPCTalking : MonoBehaviour
{
    public string FilePath;
    private string[] LINES;
    int line = 0;
    public bool talk = false;


    public GameObject player;
    private Transform PressF;


    // Start is called before the first frame update
    void Start()
    { 
        LINES = File.ReadAllLines(FilePath);
        PressF = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (talk) {
            player.GetComponent<PlayerMovement>().walk = false;
            PressF.GetComponent<Renderer>().enabled = false;
            if (Input.GetKeyDown(KeyCode.Space)) {
                    PrintLine();
                }
                if (line >= LINES.Length) {
                    line = 0;
                    talk = !talk;
                    player.GetComponent<PlayerMovement>().walk = true;
                    PressF.GetComponent<Renderer>().enabled = true;
                }
        }
    }

    public void PrintLine() {
        Debug.Log(LINES[line++]);
    }
}
