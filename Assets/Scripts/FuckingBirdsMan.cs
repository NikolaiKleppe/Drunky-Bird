using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public Rigidbody2D myRigidbody;
    public LogicManager logicManager;
    public float flapStrength = 16;
    public float gravityScale = 17;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start() {
        gameObject.name = "GrimLumberjack";
        myRigidbody.gravityScale = gravityScale;
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update() {


        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 17 || transform.position.y < -17) {
            logicManager.GameOver();
        }

    }


    private void OnCollisionEnter2D(Collision2D collision) {
        logicManager.GameOver();
        birdIsAlive = false;
    }

}
