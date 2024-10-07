using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisCollider : MonoBehaviour
{
    public GameObject Wall;
    public GameObject Collider;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Wall.SetActive(true);
        Collider.SetActive(false);
    }
}
