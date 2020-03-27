using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportadores : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject teleporter1;
    public GameObject teleporter2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < teleporter1.transform.position.x)
        {
            this.transform.position = new Vector3(teleporter2.transform.position.x, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > teleporter2.transform.position.x)
        {
            this.transform.position = new Vector3(teleporter1.transform.position.x, this.transform.position.y, this.transform.position.z);
        }

        
    }
}
