using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydisappear : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug .Log ("Body(Clone):"+collision.gameObject .name );
    //    Destroy(collision.gameObject);
    //}
    //private void OnCollisionExit(Collision collision)
    //{

    //}
    //private void OnCollisionStay(Collision collision)
    //{

    //}
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "Body(Clone)")
        {
            Destroy(col.gameObject);
        }
    }
}
