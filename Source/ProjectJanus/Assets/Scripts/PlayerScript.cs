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

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.angularVelocity = new Vector3(0.0f, -2.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.angularVelocity = new Vector3(0.0f, +2.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce( transform.forward * 12.5f );
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce( -transform.forward * 12.5f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce( Vector3.up * 500 );
        }
    }
}
