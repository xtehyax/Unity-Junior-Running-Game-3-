using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour

{
    public float speed = 15;
    private PlayerController playerControllerScript;
    public float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
            GameObject.Find("Player").GetComponent<PlayerController>(); //finds the player object and gets the PlayerController script
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false) //if the game is not over, move the background to the left
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) //if the obstacle goes out of the screen, destroy it
        {
            Destroy(gameObject);
        }
    }
}
