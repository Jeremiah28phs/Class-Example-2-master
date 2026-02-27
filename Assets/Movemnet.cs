using UnityEngine;

public class Movemnet : MonoBehaviour
{
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
//Aplication.targetFrameRate=30;
    // Update is called once per frame
    void Update()
    {
        transform.position+=Vector3.forward * Time.deltaTime * moveSpeed * Input.GetAxisRaw("Vertical"); 
       

       //Side - to - side
        transform.position+=Vector3.right * Time.deltaTime * moveSpeed * Input.GetAxisRaw("Horizontal"); 

        //up
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position+= Vector3.up * Time.deltaTime * moveSpeed;
        }
    }
}