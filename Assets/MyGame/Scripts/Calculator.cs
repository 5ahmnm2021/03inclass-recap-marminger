using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField zahl1;
    public InputField zahl2;
    public Text ergebnis;

    public void Addition()
    {
        float zahl1Float = 0;
        float zahl2Float = 0;
        bool num1 = true;
        bool num2 = true;
        string fehlerText = "Zahl versuchen!";

        try
        {
            zahl1Float = float.Parse(zahl1.text);
            zahl1.image.color = new Color32(255, 255, 255, 255);
            num1 = true;
        }
        catch
        {
            zahl1.image.color = new Color32(255, 0, 0, 255);
            zahl1.text = fehlerText;
            num1 = false;
        }

        try
        {
            zahl2Float = float.Parse(zahl2.text);
            zahl2.image.color = new Color32(255, 255, 255, 255);
            num2 = true;
        }
        catch
        {
            zahl2.image.color = new Color32(255, 0, 0, 255);
            zahl2.text = fehlerText;
            num2 = false;
        }

        if (num1 && num2)
        { 
            ergebnis.text = (zahl1Float + zahl2Float).ToString();
        }
        else
        {
            ergebnis.text = "No Result";
        }
    }
}
