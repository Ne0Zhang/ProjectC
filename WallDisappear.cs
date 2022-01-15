using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDisappear : MonoBehaviour
{
    public List<GameObject> Walls;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
            foreach(GameObject wall in Walls) {
                wall.GetComponent<Renderer>().enabled = false;
            }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player"))
            foreach(GameObject wall in Walls) {
                wall.GetComponent<Renderer>().enabled = true;
            }
    }
}
