using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CameraManager : MonoBehaviour
{
    float maxDistance = 15f;
    Camera cam;
    Vector3 mousePosition;

    // Start is called before the first frame update
     void Start(){
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) {
            Transform objectHit = hit.transform;
            //Debug.Log(ray);
            // Do something with the object that was hit by the raycast.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
