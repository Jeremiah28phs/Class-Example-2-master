using UnityEngine;

public class ProjectJohnson : MonoBehaviour


{
  
   public float  moveSpeed;
   public float jumpForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+=Vector3.forward * Time.deltaTime * moveSpeed * Input.GetAxisRaw("Vertical"); 
               //Side - to - side
        transform.position+=Vector3.right * Time.deltaTime * moveSpeed * Input.GetAxisRaw("Horizontal"); 

     /// Jumping 
     
       
   
       if (Input.GetKeyDown(KeyCode.Space))
        {
           
        }
   
    }     


}
