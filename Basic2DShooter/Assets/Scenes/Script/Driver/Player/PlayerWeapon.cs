using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PlayerWeapon : MonoBehaviour
{
    [Header("WeaponStats")]
    [SerializeField] float stats_WeaponFireRate;
    [SerializeField] GameObject weapon_Projectile;
    [SerializeField] Transform projectile_SpawnPoint;
    public float magn, rough, fadeIn, fadeOut;
    Vector3 posInf = new Vector3(0.25f, 0.25f, 0.25f);
    Vector3 rotInf = new Vector3(1, 1, 1);

    [Header("WeaponEffect")]
    [SerializeField] ParticleSystem weapon_Effect;
    [SerializeField] GameObject weapon_Light;
    float nexttime_ToFire;

    CameraShakeInstance shake;
    FeedbackManager s_FeedbackManager;

    public float combo_Counter;


    private void Start()
    {
        s_FeedbackManager = FindObjectOfType<FeedbackManager>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire") && Time.time >= nexttime_ToFire)
        {
            nexttime_ToFire = Time.time + 1f / stats_WeaponFireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject p = Instantiate(weapon_Projectile, projectile_SpawnPoint.transform.position, projectile_SpawnPoint.transform.rotation);
        if (s_FeedbackManager.WeaponFireActivate)
        {
            GameObject l = Instantiate(weapon_Light, projectile_SpawnPoint.transform.position, projectile_SpawnPoint.transform.rotation);
            weapon_Effect.Play();

        }
    }
}
