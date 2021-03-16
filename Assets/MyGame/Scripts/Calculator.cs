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

    private bool num1 = true;
    private bool num2 = true;


    public void Addition()
    {
        // Try & catch vesucht Try auszuführen bei error führt es catch aus.
        // In dem Fall wird die Farbe der Box geändert. 
        

        try
        {
            Zahl1Float = float.Parse(Zahl1.text);
            Zahl1.image.color = new Color32(255, 255, 255, 255);
            num1 = true;
        }

        catch (System.Exception)
        {
            Zahl1.image.color = new Color32(255, 0, 0, 255);
            Zahl1.text = "Zahl versuchen!";
            num1 = false;
        }

        try
        {
            Zahl2Float = float.Parse(Zahl2.text);
            Zahl2.image.color = new Color32(255, 255, 255, 255);
            num2 = true;
        }

        catch (System.Exception)
        {
            Zahl2.image.color = new Color32(255, 0, 0, 255);
            Zahl2.text = "Zahl versuchen!";
            num2 = false;
        }

        if (num1 == true && num2 == true)

        { 
            Ergebnis.text = (Zahl1Float + Zahl2Float).ToString();
        }

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
