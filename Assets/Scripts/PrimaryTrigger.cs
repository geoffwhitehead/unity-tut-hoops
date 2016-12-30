using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        print("triger entered" + other);
        GetComponentInChildren<SecondaryTrigger>().ExpectCollider(other);
    }
}
