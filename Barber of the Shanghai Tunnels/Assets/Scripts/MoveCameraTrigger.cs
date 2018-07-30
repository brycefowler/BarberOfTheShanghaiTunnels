using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraTrigger : MonoBehaviour {

    public GameObject camera;
    public float xShift;
    public float yShift;
    public float shiftMultiplier;

    void OnCollisionEnter2D(Collision2D other)
    {
        camera.transform.position = new Vector3 (camera.transform.position.x + (xShift * shiftMultiplier), 
            camera.transform.position.y + (yShift * shiftMultiplier), camera.transform.position.z);
    }


}
