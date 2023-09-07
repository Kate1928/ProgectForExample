using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button AudioBut, StopBut;
    public Sprite audioSprite, stopSprite;
    //public AudioSource audio;
    public AudioSource audio;
    
    public void MainStartButton(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
        Debug.Log("MainStartButton");
    }
    
    public void QestionButton()
    {
        Debug.Log("QestionButton");
    }
    
    public void AudioButton(Sprite sprite)
    {
        if(!audio.isPlaying)
        {
            audio.Play();
            AudioBut.image.sprite = audioSprite;
        }  
        else
        {
            audio.Stop();
            AudioBut.image.sprite = sprite;
        } 
        Debug.Log("AudioButton");       
    } 
    
    public void HomeButton(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
        Debug.Log("HomeButton");
    }

    public void StopButton(Sprite sprite)
    {
        if(Time.timeScale == 1f)
        {
            StopBut.image.sprite = stopSprite;
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1f;
            StopBut.image.sprite = sprite;
        }
        Debug.Log("StopButton");

    }
}
