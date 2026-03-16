using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiaEscena : MonoBehaviour
{
    public void CargarEscena(int Nescene)
    {
        SceneManager.LoadScene(Nescene);
    }
   // public void CargarOriginal()
    //{
      //  SceneManager.LoadScene(0);
    //}
}
