using UnityEngine;
using System.Collections;

public class obstacle : MonoBehaviour
{
    public Vector3 movspeed;
    public float deadzone = -5;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + movspeed * Time.deltaTime;
        if (transform.position.z < deadzone)
        {
            Destroy(gameObject);
        }
        {
            
        }
    }
}
