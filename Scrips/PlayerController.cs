using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float outOfBounce = 10.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        if(transform.position.x < -outOfBounce)
        {
            transform.position = new Vector3(-outOfBounce, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > outOfBounce)
        {
            transform.position = new Vector3(outOfBounce, transform.position.y, transform.position.z);
        }

        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}