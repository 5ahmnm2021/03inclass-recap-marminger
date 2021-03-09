using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    public InputField Zahl1;
    public InputField Zahl2;
    public Text Ergebnis;

    public float Zahl1Float;
    public float Zahl2Float;


    public void Addition()
    {
        Zahl1Float = float.Parse(Zahl1.text);
        Zahl2Float = float.Parse(Zahl2.text);
        Ergebnis.text = (Zahl1Float + Zahl2Float).ToString();

    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
