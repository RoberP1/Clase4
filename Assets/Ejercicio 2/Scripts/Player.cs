using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Gun gun;
    void Start()
    {
        gun = GetComponent<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gun.Shoot();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            gun.StartReload();
        }
    }
}
