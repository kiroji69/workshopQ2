using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using Unity.VisualScripting;
using System.Globalization;
public class Player_Controller : MonoBehaviour
{
    // Start is called before the first frame update
   SerialPort data_stream = new SerialPort("COM3",9600);
   public string receivedstring;
   public GameObject test_data;
   public Rigidbody rb;
   public float sensitivity = 0.01f;
   public string[] datas;

    void Start()
    {
        data_stream.Open();
    }
    void Update()
    {
        receivedstring=data_stream.ReadLine();

        print(receivedstring);

        test_data.transform.position = new Vector3(-7.80f,float.Parse(receivedstring, CultureInfo.InvariantCulture)/5f-4.40f,0);
    }
}


