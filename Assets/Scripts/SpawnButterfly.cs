using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButterfly : MonoBehaviour
{
    public GameObject butterfly;
    Vector2 min_X;
    Vector2 max_X;
    Vector2 pos;
    float xvalue;
    float timer, spawntime;
    float yvalue;

    void Start()
    {
        timer = spawntime = 5;
        min_X = new Vector2(-6.5f , -6.38f);
        max_X = new Vector2(6 , -12.4f);
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        xvalue = UnityEngine.Random.Range(min_X.x, max_X.x);
        yvalue = UnityEngine.Random.Range(min_X.y, max_X.y);
        pos = new Vector2(xvalue,yvalue);
        timer += Time.deltaTime;
        if(timer > spawntime + 2)
        {
            spawntime = timer;
            spawn();

        }
    }

    public void spawn()
    {
        Instantiate(butterfly, pos, Quaternion.identity);
    }
}
