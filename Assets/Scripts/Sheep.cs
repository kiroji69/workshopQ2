using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sheep : MonoBehaviour
{

    private Rigidbody2D sheepRB;
    private GM gameManager;
  
    [SerializeField] private float sheepSpeed = -4.0f;
    [SerializeField] public int pointValue = 1;

    void Start()
    {
        sheepRB = GetComponent<Rigidbody2D>();

        gameManager = GameObject.Find("GM").GetComponent<GM>();
        

    }


    void Update()
    {




        sheepRB.velocity = new Vector2(sheepSpeed, sheepRB.velocity.y);
       
        if (transform.position.x <=-10)
        {
            gameManager.defeat=true;
        }


        if (transform.position.x>=12 || transform.position.x<=-10)
        {
           
            Destroy(gameObject);
        }



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.collider.CompareTag("Player"))
        {
           
           //Debug.Log("go back sheep");
           sheepSpeed = sheepSpeed * -2;
           gameManager.UpdateScore(pointValue);



        }
    }

}
