using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupControl : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}
