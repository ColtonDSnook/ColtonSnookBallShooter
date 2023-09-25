using UnityEngine;
using System.Collections;

public class Rotator3 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 80) * Time.deltaTime);
    }
}
