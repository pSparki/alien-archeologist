using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string startMessage;
    public string updateMessage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(startMessage);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateMessage);
    }
}
