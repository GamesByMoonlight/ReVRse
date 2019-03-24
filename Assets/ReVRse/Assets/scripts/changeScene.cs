using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update


    public void ChangeScene(int sceneN)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneN);
    }
    public void ChangeScene(string sceneN)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneN);
    }




}
