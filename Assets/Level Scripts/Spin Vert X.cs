using UnityEngine;
using System.Collections;

public class Rotator8 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(80, 0, 0) * Time.deltaTime);
    }
}