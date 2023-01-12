using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    private GameManager gameManager;
    private ScoreHandler scoreHandler;

    private float gravityAccelerration = 10f;
    private bool isGrounded = false;
    private bool isHittingLeftBarrier = false;
    private bool isHittingRightBarrier = false;



    private float forwardAcceleration = 5f;
    private float maxForwardSpeed = 50f;
    private float forwardSpeed = 0;



    private float breakDeceleration = 25f;
    private float windDeceleration = 0.5f;


    private float turningSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        scoreHandler = GetComponent<ScoreHandler>();
    }

    void ApplyAcceleration(ref float speed, float acceleration, float maxSpeed, float minSpeed, bool isDeceleration = false)
    {
        if (!isDeceleration && speed <= maxSpeed) speed += acceleration * Time.deltaTime;
        else if (isDeceleration && speed >= minSpeed) speed -= acceleration * Time.deltaTime;
    }

    void ApplyMovement(Vector3 direction, float speed)
    {
        if (speed > 0)
            transform.position += direction * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver())
        {
            this.enabled = false;
        }

        if (!isGrounded)
        {
            float newY = transform.position.y - gravityAccelerration * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        }

        turningSpeed = 30f * forwardSpeed / 100;

        if (Input.GetKey("w"))
        {
            ApplyAcceleration(ref forwardSpeed, forwardAcceleration, maxForwardSpeed, 0);
        }
        if (Input.GetKey("s"))
        {
            ApplyAcceleration(ref forwardSpeed, breakDeceleration, maxForwardSpeed, 0, true);
        }
        if (!isHittingLeftBarrier && Input.GetKey("a"))
        {
            isHittingRightBarrier = false;
            ApplyMovement(-transform.right, turningSpeed);
        }
        if (!isHittingRightBarrier && Input.GetKey("d"))
        {
            isHittingLeftBarrier = false;
            ApplyMovement(transform.right, turningSpeed);
        }
        ApplyAcceleration(ref forwardSpeed, windDeceleration, maxForwardSpeed, 0, true);
        ApplyMovement(transform.forward, forwardSpeed);
        scoreHandler.incrementScore(forwardSpeed * Time.deltaTime);

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Road")
        {
            isGrounded = true;
        }
        if (collision.collider.name == "LimitRight")
        {
            isHittingRightBarrier = true;
        }
        if (collision.collider.name == "LimitLeft")
        {
            isHittingLeftBarrier = true;
        }
    }
}
