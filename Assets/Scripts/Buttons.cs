using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public GameObject pausePanel;
    Vector2 min_x;
    Vector2 max_x;
    Vector2 pos;
    float xvalue;
    float timer, spawntime;
    public GameObject fireball;

    void Start()
    {
        min_x = new Vector2(-7.5f, 7.4f);
        min_x = new Vector2(6, 7.4f);
    }
  
    void FixedUpdate()
    {
        xvalue = UnityEngine.Random.Range(min_x.x, max_x.x);
        pos = new Vector2(xvalue, 7.4f);
        timer += Time.deltaTime; 
        if (timer > spawntime + 2)
        {
            spawntime = timer;
            spawn();
        }
    }

    public void spawn()
    {
        Instantiate(fireball, pos, Quaternion.identity);
    }

    public void pauseScreen()
    {
        pausePanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void resumeScreen()
    {
        pausePanel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void restartScene()
    {
        SceneManager.LoadScene("LOGO");
    }
}