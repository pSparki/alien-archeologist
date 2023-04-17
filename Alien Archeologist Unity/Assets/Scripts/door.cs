using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    // public variables editable in unity
    public string targetScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ChangeScene();

        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
