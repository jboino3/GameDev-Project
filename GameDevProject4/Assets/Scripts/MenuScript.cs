using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public Canvas maincanvas;
    public Canvas levelcanvas;
    public Canvas instructioncanvas;
   
   void Start() {
            Time.timeScale = 1;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    public void QuitScene()
    {
        Application.Quit();
    }

    public void LoadInstructins()
    {
        instructioncanvas.enabled = true;
        maincanvas.enabled = false;
        levelcanvas.enabled = false;
    }
    public void HideInstructins()
    {
        instructioncanvas.enabled = false;
        levelcanvas.enabled = true;
        maincanvas.enabled = true;
    }
    

    public void LoadMenu()
    {
        ShowCanvas();
    }

    public void PlayGame()
    {
        HideCanvas();
    }

    public void Loadlevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Loadlevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Loadlevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    
    public void HideCanvas()
        {
            // Set the Canvas GameObject to inactive, making it invisible
            maincanvas.enabled = false;
        }
    
    public void ShowCanvas()
    {
        // Set the Canvas GameObject to active, making it visible
        maincanvas.enabled = true;
    }

    

}
