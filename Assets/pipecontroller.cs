using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipecontroller : MonoBehaviour
{

    public float pipeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
    }
}
