using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject focalPoint;
    private Rigidbody playerRb;
    public float speed = 5.0f;
    int hitCount;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            print("collsion");
            //hitCount++;
          
            //if (hitCount > 2) ;
            //{
               
                Destroy(other.gameObject);
                transform.localScale = new Vector3(transform.localScale.x + 0.2f , transform.localScale.y + 0.2f, transform.localScale.z + 0.2f);
          // }

        }
       // print(hitCount);
    }
}
