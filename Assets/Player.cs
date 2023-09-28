using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0.01f;
    private Rigidbody rb;
    public string restart;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.z = Input.GetAxis("Vertical");
        GetComponent<Rigidbody>().velocity = moveDirection * speed; ;

        moveDirection.Normalize();

        
        transform.forward = moveDirection;

  

        /*if (Input.GetKey(KeyCode.A))
        {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, speed) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;

        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Enemy"))
        {
            SceneManager.LoadScene(restart);
        }
    }
}
