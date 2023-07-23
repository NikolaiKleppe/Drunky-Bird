using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public Rigidbody2D myRigidbody;
    public float flapStrength = 16;
    public float gravityScale = 17;

    // Start is called before the first frame update
    void Start() {
        gameObject.name = "GrimLumberjack";
        myRigidbody.gravityScale = gravityScale;
    }

    // Update is called once per frame
    void Update() {


        if (Input.GetKeyDown(KeyCode.Space) == true) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }



    }




}
