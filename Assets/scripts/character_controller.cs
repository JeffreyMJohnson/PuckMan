using UnityEngine;
using System.Collections;

public class character_controller : MonoBehaviour
{

    public float maxVelocity;

    private float direction = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
        {
            transform.Translate(new Vector3(0, maxVelocity * Time.deltaTime * Input.GetAxis("Vertical"),0));
        }
        else if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            transform.Translate(new Vector3(maxVelocity * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0));
        }


    }
}
