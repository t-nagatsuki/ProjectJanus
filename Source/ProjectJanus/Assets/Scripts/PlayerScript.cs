using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    Rigidbody rigidbody = null;

    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update (){

        rigidbody.angularVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.angularVelocity = new Vector3(0.0f, -1.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.angularVelocity = new Vector3(0.0f, +1.0f, 0.0f);
        }

        rigidbody.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 cameraForward = Vector3.Scale(rigidbody.transform.forward, new Vector3(1, 0, 1)).normalized;
            rigidbody.velocity = cameraForward * 1.0f;
        }
    }
}
