using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    public float speed;
    bool move;
    // Use this for initialization
    void Start () {
        speed = 2.3f;
        move = true;
    }
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right *speed * Time.deltaTime);
	}
}
