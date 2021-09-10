using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") *Time.deltaTime;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * speed, 0, yValue * speed );
    }
}
