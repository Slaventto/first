using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class box : MonoBehaviour, IPointerClickHandler
{
        void Update()
    {
        Instantiate(varible);
    }
            
    
        
        
        private readonly object Intantiate;

    public GameObject varible;





    

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("клик");

        Instantiate(varible);
 
       
        
    }
}
    
