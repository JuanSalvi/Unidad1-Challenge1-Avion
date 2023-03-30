using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotar elice de avion contantemente en eje Z
        transform.Rotate(Vector3.forward * Time.deltaTime * 1000);
    }
}
