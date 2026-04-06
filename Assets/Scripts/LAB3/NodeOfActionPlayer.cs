using System.Collections.Generic;
using UnityEngine;

public enum PlayerAction
{
   Mover,
   Atacar,
   Defender
}
public class NodeOfActionPlayer 
{
    public PlayerAction accion;
    public NodeOfActionPlayer next;

    public NodeOfActionPlayer(PlayerAction nuevaAccion)
    {
        accion = nuevaAccion;
        next = null;
    }

}
