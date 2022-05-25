using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Fade : MonoBehaviour
{
    public enum Type
    {
        FadeIn,
        FadeOut
    }

    [SerializeField]
    SpriteRenderer spriteRenderer;

    public Type typeFade;

    [ContextMenu("FadeIn")]
    public void FadeIn()
    {
        //Cambia el alfa a 100% en 2 segundos
        spriteRenderer.DOFade(1, 2);
    }

    [ContextMenu("FadeOut")]
    public void FadeOut()
    {
        //Cambia el alfa a 0% en 2 segundos
        spriteRenderer.DOFade(0, 2)
            .OnComplete(()=>StartGame()) // Al completarse llama a StartGame(), 
            .OnStart(()=> { Debug.Log("Inicia el Fadeout"); }); //Al iniciar muestra el log.
    }

    private void Start()
    {
        if(typeFade == Type.FadeOut)
        {
            FadeOut();
        }

        if(typeFade == Type.FadeIn)
        {
            FadeIn();
        }
    }

    private void StartGame()
    {
        
    }
}
