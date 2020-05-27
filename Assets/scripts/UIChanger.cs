using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIChanger : MonoBehaviour
{
    [SerializeField] private Text _percentTextFiller;

    public void ClickPlay(Animator g_animator)
    {
       g_animator.SetTrigger("isCompressed");
    }

    public void ClickSettings(Animator g_animator)
    {
        g_animator.SetTrigger("isColored");
    }

    public void ClickCredits(Animator g_animator)
    {
        g_animator.SetTrigger("isWiggle");
    }

    public void ClickSteam(Animator g_animator)
    {
        g_animator.SetTrigger("isRotateIcon");
    }

    public void ClickShare(Animator g_animator)
    {
        g_animator.SetTrigger("isJump");
    }

    public void ClickRefresh(Animator g_animator)
    {
        g_animator.SetTrigger("isRefresh");
    }

    public void ClickExit(Animator g_animator)
    {
        g_animator.SetTrigger("isExit");
    }

    public void TextPercentFiller(float value)
    {
        _percentTextFiller.text = $"<size=110>{(int)(value*100)}</size><size=60>%</size>";
    }
}
