using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public float delayTime = 2f;
    public string sceneName;

    public void ChangeScene(string sceneN)
    {
        sceneName = sceneN;
        Invoke("DelayedAction", delayTime);
      
    }

    void DelayedAction()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

}
