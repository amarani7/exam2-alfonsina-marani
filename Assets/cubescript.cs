using UnityEngine;
using UnityEngine.InputSystem;
public class cubescript: MonoBehaviour
{
    private Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            animador.SetTrigger("happy");
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            animador.SetTrigger("sad");
        }
    }
}




