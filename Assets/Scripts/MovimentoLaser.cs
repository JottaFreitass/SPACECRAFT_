using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoLaser : MonoBehaviour
{
    public float velocLaser = 12.0f ;

    void Start()
    {
        
    }

    void Update()
    {
      transform.Translate(Vector3.up * velocLaser * Time.deltaTime);  

      if ( transform.position.y > 5.5f ){
          Destroy(this.gameObject);
      }
    }
}