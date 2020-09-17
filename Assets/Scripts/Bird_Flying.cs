using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Flying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().Translate(new Vector3(1, 0, 0) * 0.04f);
            transform.localScale = new Vector2(-1, 1); //flips the sprite

        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().Translate(new Vector3(-1, 0, 0) * 0.04f);
            transform.localScale = new Vector2(1, 1);

        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Transform>().Translate(new Vector3(0, -1, 0) *0.04f);

        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Transform>().Translate(new Vector3(0, 1, 0) * 0.04f);

        }
                
        
    }
}
