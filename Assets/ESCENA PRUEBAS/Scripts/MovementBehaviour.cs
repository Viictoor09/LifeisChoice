using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MovementBehaviour : MonoBehaviour
{
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += speed * Vector3.up * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += speed * -Vector3.up * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += speed * -Vector3.right * Time.deltaTime; 
        if (Input.GetKey(KeyCode.D))
        transform.position += speed * Vector3.right* Time.deltaTime; 
    }
}
