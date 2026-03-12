using UnityEngine;

public class CollisonScript : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {

            Debug.Log("Collided with " + collision.gameObject.name);

            if(collision.gameObject.tag == "Hazard")
   
            {
                Debug.Log("Ouch that hurt!");
            } 
    
          if(collision.gameObject.tag == "Finish")

        {
            Debug.Log("You Won");
        }
   
   
    }
}
