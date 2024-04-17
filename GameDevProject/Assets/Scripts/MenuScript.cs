using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public string canvasName;
    public Canvas canvas;
    public Canvas instructions;
    public void QuitScene()
    {
        Application.Quit();
    }

    public void LoadInstructins()
    {
        
        instructions.enabled = true;
    }
    public void HideInstructins()
    {
        
        instructions.enabled = false;
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
            canvas.enabled = false;
        }
    
    public void ShowCanvas()
    {
        // Set the Canvas GameObject to active, making it visible
        canvas.enabled = true;
    }

    

}
