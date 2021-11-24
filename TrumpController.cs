using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityStandardAssets.CrossPlatformInput;
using System.IO.Ports;
using System.Collections;

public class TrumpController : MonoBehaviour
{
    private Rigidbody player;
    private Animation an;

    //public string s;

    //public float senstivity = 0.01f;

    //SerialPort seri = new SerialPort("COM5", 19200);

    // Start is called before the first frame update
    void Start()
    {
        //seri.Open();
        //StartCoroutine(ReadDataFromSerialPort());
        player = GetComponent<Rigidbody> ();
        an = GetComponent<Animation> ();
    }

    /*IEnumerator ReadDataFromSerialPort()
    {
        while(true){
        string[] values = seri.ReadLine().Split(',');
        y = (float.Parse(values[1]))/100;
        x = (float.Parse(values[0]))/100;
        yield return new WaitForSeconds (.05f);
        }
    }*/

    //public string[] values;

    float x;
    float y;
    // Update is called once per frame
    void Update()
    {
        x = CrossPlatformInputManager.GetAxis("Horizontal");
        y = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3 (x, 0, y);
        player.velocity = movement * 4f;
        
        //s = seri.ReadLine();
        //string[] values = seri.ReadLine().Split(',');
        //y = (float.Parse(values[1]))/100;
        //x = (float.Parse(values[0]))/100;
       // yield return new WaitForSeconds (.05f);
        //Debug.Log("Working");

        //player.AddForce(0, 0, float.Parse(values[0])*senstivity * Time.deltaTime, ForceMode.VelocityChange);
        //player.AddForce(float.Parse(values[1])*senstivity * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        if(x !=0 || y != 0)
        {
            an.Play ("walk");
        }
        else{
            an.Play ("idle");
        }


    }
}
