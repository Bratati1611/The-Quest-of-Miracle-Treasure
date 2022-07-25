using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Movement move;
    public float platformspeed = 2f;
    bool moveright = true;

    void Start()
    {

    }

    void Update()
    {
        if(move.ismoving == true)
        {
            if (transform.position.x > 6.62f)
                moveright = false;
            if (transform.position.x < -4.34f)
                moveright = true;
            if (moveright == true)
                transform.Translate(Vector2.right*platformspeed*Time.deltaTime);
            else
                transform.Translate(Vector2.left*platformspeed*Time.deltaTime);

        }
    }

}
