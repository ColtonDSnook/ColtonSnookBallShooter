using UnityEngine;
using System.Collections;

public class Rotator7 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(220, 0, 0) * Time.deltaTime);
    }
}