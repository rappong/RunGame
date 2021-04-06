using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrolingOnject : MonoBehaviour
{
    public float speed = 10f;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
