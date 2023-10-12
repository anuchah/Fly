using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blades : MonoBehaviour
{
    [SerializeField]
    public float rotateSpeed = 0.6f;

    private void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }
}
