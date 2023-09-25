using UnityEngine;
using System.Collections;

public class Rotator5 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 120, 0) * Time.deltaTime);
    }
}
