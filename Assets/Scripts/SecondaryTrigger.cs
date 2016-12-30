using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

    private Collider expecting;

    public void ExpectCollider(Collider other)
    {
        expecting = other;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == expecting)
        {
            FindObjectOfType<ScoreKeeper>().IncrementScore(1);
        }
    }
}
