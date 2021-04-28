using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    public void Fire()
    {
        Instantiate(projectile, transform.GetChild(0).position, transform.GetChild(0).rotation);
    }

    /*
    public void Fire(GameObject projectile)
    {
        return;
    }*/
}
