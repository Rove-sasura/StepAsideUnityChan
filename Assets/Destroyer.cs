using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Unitychan‚ÌÀ•W
    public Transform target;

    ////Unitychan‚©‚ç‚Ì‹——£
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroyer‚ªUnitychan‚É’Ç”ö
        Vector3 pos = target.position;
        offset = new Vector3(0, 0, -6);

        //this.transform.position = target.position + offset;
        
        //x‚Æy‚Í0‚ÉŒÅ’è
        pos.x = 0;
        pos.y = 0;
        pos.z += offset.z;
        
        this.transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
    }

}
