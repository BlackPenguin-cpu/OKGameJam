using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameExit()
    {
        Application.Quit();
    }
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void StageExit()
    {
        SceneManager.LoadScene(0);
    }
    public void ReTry()
    {
        SceneManager.LoadScene(1);
    }
}
