using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buttom : MonoBehaviour
{


   public TMP_InputField inputField;

   public void DebugLog(){
    Debug.Log("Buttom pressed"+ inputField.text);
   }
}
