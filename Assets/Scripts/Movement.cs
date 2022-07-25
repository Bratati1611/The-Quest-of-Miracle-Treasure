using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    float speed = 3f;
    public bool ismoving = false;
    float force = 12f;
    Rigidbody2D rb;
    public GameObject key;
    public GameObject jailBar;
    bool keyCollected = false;
    public Animator anim;
    public float count;
    float health = 10;
    bool isflip = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = this.GetComponent<Animator>();
        anim.SetInteger("move", 0);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            ismoving = true;
        if (!Input.anyKey)
            anim.SetInteger("move", 0);
        else
        {

            if (Input.GetAxis("Horizontal") > 0 && isflip == true)
            {
                transform.Rotate(0f, 180f, 0f, Space.Self);
                isflip = false;
            }

            if (Input.GetAxis("Horizontal") < 0 && isflip == false)
            {
                transform.Rotate(0f, 180f, 0f, Space.Self);
                isflip = true;
            }

            if (transform.position.x < 11 && transform.position.x > -12.5f)
            {
                print(isflip);
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                anim.SetInteger("move", 1);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow)){
            rb.AddForce(transform.up * force);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Butterfly")
        {
            SceneManager.LoadScene("Game_Over");
        }

        if (collision.gameObject.name == "Key")
        {
            Destroy(key.gameObject);
            keyCollected = true;
            Destroy(jailBar.gameObject);
        }
        if (collision.gameObject.name == "treasure" && keyCollected == true)
        {
            SceneManager.LoadScene("You-Won");
        }
    }
}