using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class CamShake : MonoBehaviour
{
    [SerializeField]
    float magn, rough, fadeIn, fadeOut;
    [SerializeField]
    Vector3 posInf;
    [SerializeField]
    Vector3 rotInf;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ShakeCam();
        }    
    }
    public void ShakeCam()
    {
        CameraShakeInstance c = CameraShaker.Instance.ShakeOnce(magn, rough, fadeIn, fadeOut);
        c.PositionInfluence = posInf;
        c.RotationInfluence = rotInf;
    }

}
