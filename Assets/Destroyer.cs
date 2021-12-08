using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //UnitychanÇÃç¿ïW
    public Transform target;

    ////UnitychanÇ©ÇÁÇÃãóó£
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = target.position;
        offset = new Vector3(0, 0, -2);

        //this.transform.position = target.position + offset;
        
        pos.x = 0;
        pos.y = 0;
        pos.z += offset.z;
        
        this.transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        //{
        //    Destroy(other.gameObject);
        //}

        Debug.Log(other.gameObject.tag);

        Destroy(other.gameObject);

        //if (other.gameObject.tag == "TrafficConeTag")
        //{
        //    Destroy(other.gameObject);
        //}

    }

}
