using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
    float accelerationx;
    float deccelerationx;
    bool col;
	// Use this for initialization
	void Start () {
        accelerationx = 0.02f;
        deccelerationx = 0.02f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
            if (accelerationx < 1)
            {
                accelerationx += 0.02f;
            }
        if (Input.GetKey(KeyCode.DownArrow))
            if (deccelerationx < 1)
            {
                deccelerationx -= 0.02f;
            }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -6, 0);
            if (accelerationx + deccelerationx >= 0)
            {
                transform.Translate(0.2f, 0, 0);
            }
            else
            {
                transform.Translate(-0.2f, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 6, 0);
            if (accelerationx + deccelerationx >= 0)
            {
                transform.Translate(0.2f, 0, 0);
            }
            else
            {
                transform.Translate(-0.2f, 0, 0);
            }
        }
        if (accelerationx > 0)
        {
            accelerationx -= 0.004f;
        }
        if (deccelerationx < 0)
        {
            deccelerationx += 0.004f;
        }
        if (col == true)
        {
            accelerationx = 0;
            deccelerationx = 0;
        }
        transform.Translate(accelerationx + deccelerationx, 0, 0);
        Physics.gravity = new Vector3(0, -160, 0);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "1" || collision.gameObject.name == "2" || collision.gameObject.name == "3" || collision.gameObject.name == "4" || collision.gameObject.name == "5" || collision.gameObject.name == "6" || collision.gameObject.name == "7" || collision.gameObject.name == "8" || collision.gameObject.name == "9")
        {
            col = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "1" || collision.gameObject.name == "2" || collision.gameObject.name == "3" || collision.gameObject.name == "4" || collision.gameObject.name == "5" || collision.gameObject.name == "6" || collision.gameObject.name == "7" || collision.gameObject.name == "8" || collision.gameObject.name == "9")
        {
            col = false;
        }
    }
}
