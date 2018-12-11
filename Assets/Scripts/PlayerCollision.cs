using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public BallController controller;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "RestartTrigger")
        {
            controller.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
     }
}
