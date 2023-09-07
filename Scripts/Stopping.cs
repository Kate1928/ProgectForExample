using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stopping : MonoBehaviour
{
    public GameObject Restart;
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.collider.name == "MainCloud(Clone)")
        {
            Time.timeScale = 0;
            Restart.SetActive(true);
        }
        
       
        
    }
    public void RestartButtton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
