using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColorGiver : MonoBehaviour {

    public Button Button1, Button2, Button3;
    public GameObject Image;
 
    private void Start()
    {
        
       
        StartCoroutine(ButtonColor());
        if (BtnPress.count == 5)
        {
           SceneManager.LoadScene("Right");
        }
        
       

    }
  IEnumerator ButtonColor()
    {
        Button1.image.color = ColourRec.myButtonsColor1;
      Button2.image.color = ColourRec.myButtonsColor2;
        Button3.image.color = ColourRec.myButtonsColor3;
        BtnPress.count++;
       yield return new WaitForSeconds(1.0f);
        

    }
}
