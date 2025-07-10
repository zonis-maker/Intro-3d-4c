using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clonador : MonoBehaviour
{
    public GameObject cuboPrefab;

    public void ClonarCubo()
    {
        Instantiate(cuboPrefab);
    }
}
