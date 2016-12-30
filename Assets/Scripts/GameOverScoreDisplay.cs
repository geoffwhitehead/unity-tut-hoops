using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScoreDisplay : MonoBehaviour {

    Text text;
    ScoreAbsorber sa;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        sa = FindObjectOfType<ScoreAbsorber>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + sa.score;
    }
}
