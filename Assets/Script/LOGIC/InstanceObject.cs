using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObject : MonoBehaviour
{
    public GameObject objectInstantiate;
    public GameObject circleRootPlayer;

    private void Start()
    {
        Instantiate(objectInstantiate, new Vector3(573f, 448.3f, 2f), Quaternion.identity);
        Instantiate(circleRootPlayer, new Vector3(573.082f, 488.6f, 0f), Quaternion.identity);


    }

}
