using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    [SerializeField] Image combo_BackGround;
    [SerializeField] Text combo_Text;

    [SerializeField] public float timer = 0;
    [SerializeField] float duration = 10;


    [SerializeField] float min_size;
    [SerializeField] float max_size;

    PlayerWeapon s_PlayerWeapon;


    float LinearLerp(float start, float end, float value)
    {
        return (1 - value) * start + value * end;
    }
    void Swap(float lhs, float rhs)
    {
        max_size = lhs;
        min_size = rhs;
    }
    private void Start()
    {
        s_PlayerWeapon = FindObjectOfType<PlayerWeapon>();
    }
    // Update is called once per frame
    void Update()
    {
        if (timer <= duration)
            LerpSize();
    }
    public void LerpSize()
    {
        //***EXPANDING UI***//
        //--WHAT IT DOES--//
        /* Upon hitting the enemy, the Combo image will decrease in size and quickly increasing in size(pop effect)
        //Research note//
        /*
         * Made the impact feel more impactful thanks to the pop effect
         */
        timer += Time.deltaTime;
        combo_BackGround.transform.localScale = new Vector2(LinearLerp(min_size, max_size, timer / duration), LinearLerp(min_size, max_size, timer / duration));
        combo_Text.text = s_PlayerWeapon.combo_Counter.ToString() + "x";
    }
}
