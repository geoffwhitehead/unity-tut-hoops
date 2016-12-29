using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;
    float velocity = 5.0f;

    enum directions { UP, DOWN, LEFT, RIGHT, NONE };
    directions gl_dir = directions.NONE;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        if (getDirection() != directions.NONE)
        {
            gl_dir = getDirection();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            setBallVelocity(rb, gl_dir);
        }
	}

    void setBallVelocity(Rigidbody rb, directions d)
    {
        switch (d)
        {
            case directions.LEFT:
                rb.velocity = Vector3.left * velocity;
                break;
            case directions.RIGHT:
                rb.velocity = Vector3.right * velocity;
                break;
            case directions.UP:
                rb.velocity = Vector3.back * velocity;
                break;
            case directions.DOWN:
                rb.velocity = Vector3.forward * velocity;
                break;
            default:
                rb.velocity = new Vector3(0, 0, 0);
                break;
        }
    }

    directions getDirection()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           return directions.LEFT;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return directions.RIGHT;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            return directions.UP;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            return directions.DOWN;
        }
        return directions.NONE;
    }
}
