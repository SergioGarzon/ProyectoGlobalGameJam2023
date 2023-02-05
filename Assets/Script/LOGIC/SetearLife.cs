using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetearLife : MonoBehaviour
{
    public LifeData life;

    public void Start()
    {
        life.life = 100;
    }
}
