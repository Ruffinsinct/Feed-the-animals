using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] float topBound = 30.0f;
    [SerializeField] float bottomBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomBound)
        {
            Debug.Log("GameOver! Loser!!");
            Destroy(gameObject);
        }
    }
}
