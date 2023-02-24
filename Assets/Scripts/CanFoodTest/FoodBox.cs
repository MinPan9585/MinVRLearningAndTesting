using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBox : MonoBehaviour
{
    public GameObject foodPrefab;
    public int handLayer;

    private void Start()
    {
        handLayer = LayerMask.GetMask("Hand","Food");
    }

    void Update()
    {
        Collider[] handColliders = Physics.OverlapSphere(transform.position, 0.1f, handLayer);
        if(handColliders.Length==2 && handColliders[0].CompareTag("Hand") && handColliders[1].CompareTag("Hand"))
        {
            Instantiate(foodPrefab, transform);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }
}
