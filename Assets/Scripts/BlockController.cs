using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public GameObject blockResources;
    public Transform blockParent;

    void Awake()
    {
        for (int x = 0; x < 11; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                GameObject blocks = Instantiate(blockResources, blockParent);
                blocks.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
