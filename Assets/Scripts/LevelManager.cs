using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float timeUntilNextLevel = 0.0f;
	// Use this for initialization
	void Start () {
        

	}

    // Update is called once per frame
    void Update()
    {
        if (timeUntilNextLevel > 0)
        {
            timeUntilNextLevel -= Time.deltaTime;
            if (timeUntilNextLevel < 0)
            {
                LoadNextScene();
            }

        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }



}
