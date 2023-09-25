using UnityEngine;
using System.Collections;

public class Rotator4 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -80) * Time.deltaTime);
    }
}
