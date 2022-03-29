using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    public PlMov movement;
    


   void OnCollisionEnter (Collision collisionInfo)
    {
       if (collisionInfo.collider.tag == "Enem")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();


        }

    }
}
