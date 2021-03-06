using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    //Unitychanの座標
    public Transform target;

    ////Unitychanからの距離
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //DestroyerがUnitychanに追尾
        Vector3 pos = target.position;
        offset = new Vector3(0, 0, -6);

        //this.transform.position = target.position + offset;
        
        //xとyは0に固定
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
