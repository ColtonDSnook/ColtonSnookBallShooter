using UnityEngine;
using System.Collections;

public class Rotator6 : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 120) * Time.deltaTime);
    }
}
