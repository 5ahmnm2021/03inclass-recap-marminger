using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Master : MonoBehaviour
{

    public string newText;
    public InputField i;

    public int newSize;
    public Text t;

    public bool loop;
    public VideoPlayer v;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i.text = newText;
        t.fontSize = newSize;
        v.isLooping = loop;
    }
}
