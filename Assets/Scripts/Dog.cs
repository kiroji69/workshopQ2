using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using Unity.VisualScripting;
using System.Globalization;
using System.Drawing;
using UnityEngine.UI;
using UnityEditor;

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

    SerialPort data_stream = new SerialPort("COM3",9600);
   public string receivedstring;
   public float standardBark = 3.0f;
   public string[] datas;

    void Start()
    {
        data_stream.Open();
        playerRB = GetComponent<Rigidbody2D>();
        smallBark = GameObject.Find("SmallBark");
        bigBark = GameObject.Find("BigBark");
        bigBark.SetActive(false);
    }


    void Update()
    {
        standardBark =3.0f;
        receivedstring=data_stream.ReadLine();
        datas = receivedstring.Split(',');
        playerRB.transform.position = new Vector3(-7.80f,float.Parse(datas[1], CultureInfo.InvariantCulture)/5f-4.40f,0);
        float vertical = Input.GetAxis("VerticalKey");





/*     
         // Vertical MVT

        if ((playerRB.position.y < 3.9f && vertical > 0) || (playerRB.position.y > -3.9f && vertical < 0))
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, vertical * moveSpeed);
        }
        else
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, 0);
        }


*/


        //bark

        bool bark = false;

         if (int.Parse(datas[0],CultureInfo.InvariantCulture)>350){
           
            while(standardBark>0){
               standardBark -= Time.deltaTime;
               smallBark.SetActive(true);
            }
            print(bark+","+datas[0]);
         }
        
        else{
            smallBark.SetActive(false);
        }
        
        


    }

}
