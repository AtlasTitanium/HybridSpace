using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourRec : MonoBehaviour {

    public static Color myButtonsColor1, myButtonsColor2, myButtonsColor3;
    public Button Button1, Button2, Button3;
 //   public GameObject cube;
 
    public void button1()
    {
    myButtonsColor1= Button1.image.color;
      //  Debug.Log("Reaching button1");
      //  cube.GetComponent<Renderer>().material.color = Button1.image.color;

    }
    public void button2()
    {
       myButtonsColor2 = Button2.image.color;
 //       cube.GetComponent<Renderer>().material.color = Button1.image.color;


    }
    public void button3()
    {
        myButtonsColor3 = Button3.image.color;
 //       cube.GetComponent<Renderer>().material.color = Button1.image.color;


    }
 
}
