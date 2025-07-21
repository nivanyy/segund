using TMPro;
using UnityEngine;

public class botãotexto : MonoBehaviour
{
   public string texto;
   public TextMeshProUGUI textoUI;


   public void trocartexto()
   {
      textoUI.text = texto;
   }
   
}
