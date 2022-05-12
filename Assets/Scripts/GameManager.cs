using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameover = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameover)
        {
            Invoke("Restart", 3);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);

        isGameover = false;
    }
}
