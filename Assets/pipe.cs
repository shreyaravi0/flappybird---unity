using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadzone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
         }
    }
}
