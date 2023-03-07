using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject CollectableObj;

    public int CollectableNum;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < CollectableNum; i++)
        {
            //Vector3 newPos = new Vector3(transform.position.x + (i * 2), transform.position.y, transform.position.z);
            Vector3 newPos = new Vector3(transform.position.x + Random.Range(-10, 10), transform.position.y, transform.position.z + Random.Range(-10, 10));
            Instantiate(CollectableObj, newPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
