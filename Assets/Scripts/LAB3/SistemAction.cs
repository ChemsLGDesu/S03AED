using System.Collections;
using UnityEngine;

public class SistemAction : MonoBehaviour
{
    private NodeOfActionPlayer inicio;
    private NodeOfActionPlayer fin;

    public void InputMover() => AgregarAccion(PlayerAction.Mover);
    public void InputAtacar() => AgregarAccion(PlayerAction.Atacar);
    public void InputDefender() => AgregarAccion(PlayerAction.Defender);
    public void BotonPlay() => EjecutarTurno();

    public void  AgregarAccion(PlayerAction accion)
    {
        NodeOfActionPlayer nuevoNodo = new NodeOfActionPlayer(accion);
        
        if (inicio == null)
        {
            inicio = nuevoNodo;
            fin = nuevoNodo;
        }
        else
        {
            fin.next = nuevoNodo;
            fin = nuevoNodo;
        }
        Debug.Log("Acción añadida a la cola: " + accion);
    }

    public void EjecutarTurno()
    {
        if (inicio == null)
        {
            Debug.LogWarning("No hay acciones en la lista");
            return;
        }
        StartCoroutine(RutinaEjecucion());
    }

    private IEnumerator RutinaEjecucion()
    {
        NodeOfActionPlayer actual = inicio;
        Debug.Log("Iniciando Repetición Automática del Turno");

        while (actual != null)
        {
            Debug.Log("Ejecutando acción: " + actual.accion);
            actual = actual.next;
            yield return new WaitForSeconds(1.0f);
        }

        Debug.Log("Fin de la secuencia");

        inicio = null;
        fin = null;
    }
}
