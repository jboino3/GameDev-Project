using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuImage : MonoBehaviour
{
    // Start is called before the first frame update
    public Image levelImage;
    public Sprite lvl1;
    public Sprite lvl2;
    public Sprite lvl3;
    
    
    

    public void ChangeImagelvl1()
    {
        levelImage.sprite = lvl1; 
        levelImage.color = Color.white; 
    }
    public void ChangeImagelvl2()
    {
        levelImage.sprite = lvl2; 
        levelImage.color = Color.white; 
    }
    public void ChangeImagelvl3()
    {
        levelImage.sprite = lvl3; 
        levelImage.color = Color.white; 
    }

    public void Playgame()
    {
        if (levelImage.sprite == lvl1)
        {
            SceneManager.LoadScene("Level 1");
        }
        else if (levelImage.sprite == lvl2)
        {
            SceneManager.LoadScene("Level 2");
        }
        else if (levelImage.sprite == lvl3)
        {
            SceneManager.LoadScene("Level 3");
        }
    }
}
