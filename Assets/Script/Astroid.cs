using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{

    [SerializeField]
    private float _rotateSpeed = 19.0f;
   
  
    // Update is called once per frame
    void Update()
    {
        //rotater object on the zed axis !
        transform.Rotate(Vector3.forward * _rotateSpeed * Time.deltaTime);

    }

    //check for laser collision (trigger)
    //instantiate exsplosion at the position of asteroid (us)
    //destroy the exslosion agter 3 seconds
}
