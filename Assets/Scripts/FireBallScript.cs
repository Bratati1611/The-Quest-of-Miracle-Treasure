using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireBallScript : MonoBehaviour
{
    Movement uis;

    void Start()
    {
    }
    void Update()
    {
        if (transform.position.y <= -12)
        {
            Destroy(this.gameObject, 5.0f);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Tikki")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

