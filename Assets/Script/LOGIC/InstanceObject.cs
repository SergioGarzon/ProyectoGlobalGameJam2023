using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObject : MonoBehaviour
{
    public GameObject objectInstantiate;
    public GameObject circleRootPlayer;
    public GameObject ObjectPhreaticZone;

    private void Start()
    {
        Instantiate(objectInstantiate, new Vector3(573f, 448.3f, 2f), Quaternion.identity);
        Instantiate(circleRootPlayer, new Vector3(573.082f, 493.1f, 0f), Quaternion.identity);
        Instantiate(ObjectPhreaticZone, new Vector3(573.082f, 393.32f, 2f), Quaternion.identity);

    }

}
