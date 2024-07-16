using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class vậtthể : MonoBehaviour
{
    public float speed;
   

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 thiênthach = new Vector2(-1,-1).normalized;
        transform.Translate(thiênthach*speed* Time.deltaTime);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("qwe"))
        {
               
            Destroy(gameObject);    
        }
    }
}
   
