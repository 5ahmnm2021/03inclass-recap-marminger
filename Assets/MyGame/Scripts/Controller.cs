using UnityEngine;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{
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
