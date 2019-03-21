using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "location1")
        {
            other.gameObject.transform.position = new Vector3(-1, 2.5f, 1.5f);
            other.gameObject.transform.rotation = new Quaternion(0,0,0,0);
        }
        else if (gameObject.tag == "location2")
        {
            other.gameObject.transform.position = new Vector3(0.5f,5,-11.25f);
        }
        else if (gameObject.tag == "location3")
        {
            other.gameObject.transform.position = new Vector3(-22.5f, 2, -12);
        }
        else if (gameObject.tag == "location4")
        {
            other.gameObject.transform.position = new Vector3(-29.5f,7,-30);
        }
        else
            Debug.LogError("Error");
    }
}
