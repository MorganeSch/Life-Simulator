using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleLife : MonoBehaviour
{
    public Particle particle;
    List<Family> families;
    List<Particle> particles;
    public float familyCount;
    public int particleCount;
    public float minDistance;
    public float maxDistance;
    public float minForce;
    public float maxForce;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        families = new List<Family>();
        particles = new List<Particle>();

        for (int i = 0; i<familyCount; i++)
        {
            families.Add(new Family());
        }
        foreach (Family family in families)
        {
            foreach (Family other in families)
            {
                family.AddRule(other, new Rule(minDistance, maxDistance, minForce, maxForce));
            }
        }
        for (int i = 0; i <particleCount; i++)
        {
            Particle p = Instantiate<Particle>(particle);
            p.transform.position = Random.insideUnitCircle * radius;
            p.family = families[Random.Range(0, families.Count)];
            particles.Add(p);
        }
    }
}
