using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

    public GameObject ballPrefab;
    public float ballSpeed = 20.0f;
    Camera camera;
    // Use this for initialization
    void Start () {
        camera = GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = (camera.transform.rotation * Vector3.forward) * ballSpeed;
        }
    }
}
