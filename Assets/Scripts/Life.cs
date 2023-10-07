using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField]
    protected int lifeAmount;

    public virtual void ChangeLife(int value)
    {
        lifeAmount += value;
    }
}