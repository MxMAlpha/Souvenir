using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{

    public float speed = 1f;
    public float min;

    Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;

        temp.x -= Time.deltaTime;

        temp.y -= Time.deltaTime;

         if(temp.x <= 0 || temp.y <= 0)
        {
            Debug.Log("game over");
        }

        transform.localScale = temp;

       // if  (transform.localScale)
            

           

        

    }
}
