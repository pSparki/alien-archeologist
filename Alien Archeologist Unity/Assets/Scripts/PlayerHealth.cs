using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth;
    public string targetScene;
    private int currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int v)
    {
        int changeAmount = -25;
        currentHealth = currentHealth + changeAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        if (currentHealth == 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        ChangeScene();
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
