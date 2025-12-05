using System.Collections.Generic;
using UnityEngine;
public class Family
{
    public Color color;
    public Dictionary<Family, Rule> rules;

    public Family()
    {
        color = Random.ColorHSV(0, 1, 1, 1, 1, 1);
        rules = new Dictionary<Family, Rule>();
    }
    public void AddRule(Family family, Rule rule)
    {
        if (rules.ContainsKey(family))
        {
            rules[family] = rule;
        }else
        {
            rules.Add (family, rule);
        }
    }
}


public class Rule
{
    public float distance;
    public float force;
    public UnityEngine.Color color;

    public Rule(float minDistance, float maxDistance, float minForce, float maxForce)
    {
        distance = Random.Range(minDistance, maxDistance);
        force = Random.Range(minForce, maxForce) * (Random.value > 0.5 ? 1 : -1);
    }
}
