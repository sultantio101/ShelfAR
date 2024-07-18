using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    public Transform PanelScanReticle;

   public void PanelHandlerFound()
   {
    PanelScanReticle.gameObject.SetActive(false);
   }

   public void PanelHandlerLost()
   {
    PanelScanReticle.gameObject.SetActive(true);
   }
}