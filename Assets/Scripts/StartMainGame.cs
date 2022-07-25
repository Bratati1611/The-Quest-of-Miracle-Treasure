using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMainGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeToScene()
    {
        SceneManager.LoadScene("GAME");
    }
}
