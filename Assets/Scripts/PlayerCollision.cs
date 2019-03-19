using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Restart")
        {
            movement.enabled = false;
            ScoreScript.scoreValue = 0;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            ScoreScript.scoreValue = 0;
            FindObjectOfType<GameManager>().EndGame();
            
        }



    }
}
