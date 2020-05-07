using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptBird : MonoBehaviour
{
    public float force;
    Rigidbody2D BirdRigid;

    void Start()
    {
        BirdRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            BirdRigid.velocity = Vector2.up * force;
        }
    }
}
