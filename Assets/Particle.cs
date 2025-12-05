using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public Family family;
    void Start()
    {
        SpriteRenderer sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.color = family.color;
    }
}
