using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InventaryBase : MonoBehaviour
{
   public List<GameObject> myObjects;

   public float delayBObj = .1f;
   public float sizeObj = .3f;

   private bool _isShowing = false; 

   [Header("Animation")]
   public Animator animator;

   public string triggerShow = "Show";
   public string triggerHide = "Hide";


   private void Awake() {
    Hide();
   }

   private void Hide(){

    _isShowing = false; 
    foreach (GameObject g in myObjects)
    {
        g.SetActive(false);
    }
   }

   public void ShowCoroutine(){

    if (_isShowing){
        Hide();
        animator.SetTrigger(triggerHide);
    }
    
    else{

        animator.SetTrigger(triggerShow);
        _isShowing = true;
        StartCoroutine(Show());
    }
    
   }

   IEnumerator Show(){
    foreach (GameObject g in myObjects){
        
        yield return new WaitForSeconds(delayBObj);
        g.SetActive(true);
        g.transform.DOScale(0, sizeObj).From();
    }
   }
}