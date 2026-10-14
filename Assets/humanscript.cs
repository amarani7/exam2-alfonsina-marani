using UnityEngine;
using UnityEngine.InputSystem;
public class humanscript : MonoBehaviour
{
    private Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            animador.SetTrigger("sentarse");
        }
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            animador.SetTrigger("levantarse");
        }
    }
}




