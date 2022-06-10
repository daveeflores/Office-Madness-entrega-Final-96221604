using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarCameraFollow : MonoBehaviour
{

    private Camera camFollow;
    // Start is called before the first frame update
    void Start()
    {
        camFollow = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - camFollow.transform.position);
    }
}
