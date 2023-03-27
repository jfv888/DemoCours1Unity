using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0) {
            rb.AddForce(new Vector3(0, 0, Input.GetAxis("Vertical") * Time.deltaTime) * 1000);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0) * 1000);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(0);
        }
    }
}
