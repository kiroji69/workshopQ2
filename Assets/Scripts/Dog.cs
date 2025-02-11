using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    [Header("movement Settings")]
    [SerializeField] private float moveSpeed = 8.0f;
    [SerializeField] private int points = 0;
    [SerializeField] private float barkCount = 0f;

    [Header("References")]


    private Rigidbody2D playerRB;
    private GameObject smallBark;
    private GameObject bigBark;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        smallBark = GameObject.Find("SmallBark");
        bigBark = GameObject.Find("BigBark");
        bigBark.SetActive(false);
    }


    void Update()
    {

        float vertical = Input.GetAxis("VerticalKey");





        // Vertical MVT

        if ((playerRB.position.y < 3.9f && vertical > 0) || (playerRB.position.y > -3.9f && vertical < 0))
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, vertical * moveSpeed);
        }
        else
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, 0);
        }





        //bark

        bool bark = Input.GetButton("Fire1");



        smallBark.SetActive(bark);

        if (bark == true)
        {
            barkCount += Time.deltaTime;
        }
        if (bark == true && barkCount > 1.0f)
        {
            //Debug.Log((barkCount).ToString("00:00.00"));
            bigBark.SetActive(bark);
            smallBark.SetActive(false);
        }

        if (bark == false)
        {
            barkCount = 0;
            bigBark.SetActive(bark);
        }



    }

}
