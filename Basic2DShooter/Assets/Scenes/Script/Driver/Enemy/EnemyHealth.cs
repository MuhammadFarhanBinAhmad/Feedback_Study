using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class EnemyHealth : MonoBehaviour
{
    public float health;

    [Header("Effects")]
    [SerializeField] GameObject effect_Explosion;
    Combo s_Combo;
    PlayerWeapon s_PlayerWeapon;
    FeedbackManager s_FeedbackManager;

    public float magn, rough, fadeIn, fadeOut;
    Vector3 posInf = new Vector3(0.25f, 0.25f, 0.25f);
    Vector3 rotInf = new Vector3(1, 1, 1);


    private void Start()
    {
        s_Combo = FindObjectOfType<Combo>();
        s_PlayerWeapon = FindObjectOfType<PlayerWeapon>();
        s_FeedbackManager = FindObjectOfType<FeedbackManager>();
    }

    public void TakingDamage(float dmg)
    {
        health -= dmg;
        if (health > 0)
        {
            if(s_FeedbackManager.CameraShakeActivate)
            {
                CameraShakeInstance c = CameraShaker.Instance.ShakeOnce(magn, rough, fadeIn, fadeOut);
                c.PositionInfluence = posInf;
                c.RotationInfluence = rotInf;
            }
            
        }
        else
        {
            if (s_FeedbackManager.CameraShakeActivate)
            {
                CameraShakeInstance c = CameraShaker.Instance.ShakeOnce(magn * 2.5f, rough * 2.5f, .5f, .5f);
                c.PositionInfluence = posInf;
                c.RotationInfluence = rotInf;
            }
            if (s_FeedbackManager.ExplosionActivate)
            {
                Instantiate(effect_Explosion, transform.position, transform.rotation);
            }
            if (s_FeedbackManager.ShortPauseActivate)
            {
                FindObjectOfType<ShockScreen>().PauseScreen();
            }
/*            if (s_FeedbackManager.FlashScreenActivate)
            {
                FindObjectOfType<ShockScreen>().FlashScreen();
            }*/
            Destroy(this.gameObject);
        }
        if (s_FeedbackManager.ComboCounterActivate)
        {
            s_PlayerWeapon.combo_Counter++;
            s_Combo.timer = 0;
        }
    }
}
