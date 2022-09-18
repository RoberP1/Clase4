using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifiers : MonoBehaviour
{
    public bool active;

    public int amount;

    public void SetActive(bool value)
    {
        active = value;
    }
}
