using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamMovement : MonoBehaviour {
    public Transform childLeft;
    public Transform childRight;
    public GameObject cubeLeft;
    public GameObject cubeRight;
    public float speed;
    bool eBike;
	// Use this for initialization
	void Start () {
        speed = 1f;
        eBike = false;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKeyDown("s"))
        {
            speed = 1f;
        }
        if (Input.GetKeyDown("e"))
        {
            if (eBike)
            {
                speed = 1f;
                eBike = false;
            }
            else
            {
                speed = 4f;
                eBike = true;
            }
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 100 * Time.deltaTime * -1f, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 100 * Time.deltaTime * 1f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("childLeftTrigger"))
        {
            Instantiate(cubeLeft, childLeft.position, childLeft.rotation);
        }
        if (other.CompareTag("childRightTrigger"))
        {
            Instantiate(cubeRight, childRight.position, childRight.rotation); 
        }
        if (other.CompareTag("deer"))
        {
            SceneManager.LoadScene("fail");
        }
        if (other.CompareTag("finish"))
        {
            SceneManager.LoadScene("finish");
        }
        
    }

    private void Crash()
    {
        SceneManager.LoadScene("fail");
    }

    /*public float myRotationSpeed = 100.0f;

    public bool isRotateX = false;
    public bool isRotateY = false;
    public bool isRotateZ = false;

    // CHANGE TO ROTATE IN OPPOSITE DIRECTION
    private bool positiveRotation = false;

    private int posOrNeg = 1;

    // Use this for initialization
    void Start()
    {
        collider.isTrigger = true;
        if (positiveRotation == false)
        {
            posOrNeg = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //  Toggles X Rotation
        if (isRotateX)
        {
            transform.Rotate(myRotationSpeed * Time.deltaTime * posOrNeg, 0, 0);//rotates coin on X axis
                                                                                //Debug.Log("You are rotating on the X axis");	
        }
        //  Toggles Y Rotation
        if (isRotateY)
        {
            transform.Rotate(0, myRotationSpeed * Time.deltaTime * posOrNeg, 0);//rotates coin on Y axis
                                                                                //Debug.Log("You are rotating on the Y axis");
        }
        //  Toggles Z Rotation
        if (isRotateZ)
        {
            transform.Rotate(0, 0, myRotationSpeed * Time.deltaTime * posOrNeg);//rotates coin on Z axis
                                                                                //Debug.Log("You are rotating on the Z axis");
        }

    }*/

}
