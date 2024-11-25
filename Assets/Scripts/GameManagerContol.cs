using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerContol : MonoBehaviour
{
    public GameObject Enemy;
    public string Scene;
    void Update()
    {
        // es de menú a gameplay
        if(Scene == "Gameplay")
        {
            if (Input.GetButtonDown("Jump") == true)
            {
            SceneManager.LoadScene(Scene);
            }
        }
        // es de gameplay a menú
        else if (Scene == "MainMenu")
        {
            if (Enemy.tag == "Player")
            {
                SceneManager.LoadScene(Scene);
            }
        }
    }
}
