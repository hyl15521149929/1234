using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void LoadStartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnApplication()
    {
        Application.Quit();
    }
    public void ConfirmReturn()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GameShow()
    {
        SceneManager.LoadScene("GameShow");
    }
    public void Rankinglist()
    {
        SceneManager.LoadScene("Rankinglist");
    }
}
