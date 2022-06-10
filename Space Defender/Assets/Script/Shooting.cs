using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BulletPrefab;
    public float bulletForce = 20f;
    void Update()
    {
        if(Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
