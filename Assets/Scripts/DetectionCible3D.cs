using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection_Cible : MonoBehaviour

{
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Cible")){
            Destroy(collision.gameObject);
        }
    }
}
