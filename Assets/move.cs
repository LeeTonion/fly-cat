using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
public class move : MonoBehaviour
{
    public float tocdo;
    public float trai_phai;
    public float high;
    private Rigidbody2D rb;
    private Animator animation;
    private bool a = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("gioihan") || collision.CompareTag("qwe"))
        {
            SceneManager.LoadScene("kết thúc");
        }
        
    }
    void flip()
    {
        if (a && trai_phai<0 || !a && trai_phai > 0)
        {
            a = !a;
            Vector3 quay = transform.localScale;
            quay.x = quay.x * -1;
            transform.localScale = quay;    
        }
    }
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
        animation = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        
        trai_phai = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(trai_phai * tocdo, rb.velocity.y);
        flip();
        animation.SetFloat("move", Mathf.Abs(trai_phai));
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            rb.AddForce(Vector2.up * high , ForceMode2D.Impulse);
        }
        
    }
}
