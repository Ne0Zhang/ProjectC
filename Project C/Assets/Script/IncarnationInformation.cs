using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class IncarnationInformation : MonoBehaviour
{
    // public string name;
    
    // Start is called before the first frame update
    [MenuItem("Tools/Read file")]
    static void ReadString() {
        string path = "Assets/Text File/Astra1.txt";
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
