using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump1 : MonoBehaviour {
    private Rigidbody rb;
    public float jumpstrenght = 10;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key: KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jumpstrenght, ForceMode.Impulse);
        }
        if(Input.GetKey(key: KeyCode.LeftArrow))
        {
            // rb.AddForce(force: Vector3.left * jumpstrenght * 1, mode: ForceMode.VelocityChange);
            transform.Translate(translation: Vector3.left / 5);
        }
        if (Input.GetKeyDown(key: KeyCode.DownArrow))
        {
            rb.AddForce(force: Vector3.down * jumpstrenght * 3, mode: ForceMode.Impulse);
        }
        if (Input.GetKey(key: KeyCode.RightArrow))
        {
            //  rb.AddForce(force: Vector3.right * jumpstrenght * 1, mode: ForceMode.VelocityChange);
            transform.Translate(translation: Vector3.right / 5);
        }
    }
}
