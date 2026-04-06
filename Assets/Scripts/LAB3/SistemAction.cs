using UnityEngine;

public class SistemAction : MonoBehaviour
{
    private NodeOfActionPlayer inicio;
    private NodeOfActionPlayer final;
    
    public void  AgregarAccion(PlayerAction action)
    {
        NodeOfActionPlayer nuevoModo = new NodeOfActionPlayer(action);
    }
}
