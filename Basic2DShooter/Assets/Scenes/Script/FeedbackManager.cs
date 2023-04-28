using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackManager : MonoBehaviour
{
    public bool WeaponFireActivate;
    public bool CameraShakeActivate;
    public bool ExplosionActivate;
    public bool ShortPauseActivate;
    public bool ComboCounterActivate;
    public bool FlashScreenActivate;
    public bool ProjectileExplosionActivate;

    public void ActivateWeaponFire()
    {
        if (WeaponFireActivate)
        {
            WeaponFireActivate = false;
        }
        else
            WeaponFireActivate = true;
    }
    public void ActivateCameraShake()
    {
        if (CameraShakeActivate)
        {
            CameraShakeActivate = false;
        }
        else
            CameraShakeActivate = true;
    }
    public void ActivateExplosion()
    {
        if (ExplosionActivate)
        {
            ExplosionActivate = false;
        }
        else
            ExplosionActivate = true;
    }
    public void ActivateShortPause()
    {
        if (ShortPauseActivate)
        {
            ShortPauseActivate = false;
        }
        else
            ShortPauseActivate = true;
    }
    public void ActivateComboCounter()
    {
        if (ComboCounterActivate)
        {
            ComboCounterActivate = false;
        }
        else
            ComboCounterActivate = true;
    }
    public void ActivateFlashScreen()
    {
        if (FlashScreenActivate)
        {
            FlashScreenActivate = false;
        }
        else
            FlashScreenActivate = true;
    }
    public void ActivateProjectileExplosion()
    {
        if (ProjectileExplosionActivate)
        {
            ProjectileExplosionActivate = false;
        }
        else
            ProjectileExplosionActivate = true;
    }

}
