using UnityEngine;
using System.Collections;

public class Rotator2 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, -50, 0) * Time.deltaTime);
    }
}
