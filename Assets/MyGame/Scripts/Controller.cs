using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("01ColorScene");
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("02NumberScene");
    }

    public void ChangeScene3()
    {
        SceneManager.LoadScene("00WelcomeScene");
    }
}
