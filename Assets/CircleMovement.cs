using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            Input.GetAxis("Horizontal") * 5 * Time.deltaTime,
            Input.GetAxis("Vertical") * 5 * Time.deltaTime,
            0
        );
   
    }

    private void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name.Contains("Isometric Diamond")){
            Destroy(col.gameObject);
        }
        //Debug.Log(col.gameObject.name);
    }


}
