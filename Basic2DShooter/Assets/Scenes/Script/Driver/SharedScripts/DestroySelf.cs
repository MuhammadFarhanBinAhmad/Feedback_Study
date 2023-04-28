using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{

    public float time;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGameObject", time);
    }

    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
