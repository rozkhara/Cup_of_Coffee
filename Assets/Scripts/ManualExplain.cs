using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManualExplain : MonoBehaviour
{
    public GameObject Back;
    public GameObject Espresso;
    public GameObject CaramelMacchiato;
    public GameObject Americano;
    public GameObject CafeMocha;
    public GameObject Cappuchino;
    public GameObject VanillaLatte;
    public GameObject CafeLatte;
    public GameObject GreenteaLatte;
    public GameObject StrawberryLatte;
    public GameObject Choco;
    public GameObject Smoothie;
    public GameObject BubbleTea;
    public GameObject Frappuccino;

    public void Start()
    {
        /*       Espresso.SetActive(false);
               CaramelMacchiato.SetActive(false);
               Americano.SetActive(false);
               CafeMocha.SetActive(false);
               Cappuchino.SetActive(false);
               VanillaLatte.SetActive(false);
               CafeLatte.SetActive(false);
               GreenteaLatte.SetActive(false);
               StrawberryLatte.SetActive(false);
               Choco.SetActive(false);
               Smoothie.SetActive(false);
               BubbleTea.SetActive(false);
               Frappuccino.SetActive(false);
        */
    }
    public void EspressoExplain()
    {
        Back.SetActive(true);
        Espresso.SetActive(true);
    }
    public void CaramelMacchiatoExplain()
    {
        Back.SetActive(true);
        CaramelMacchiato.SetActive(true);
    }
    public void AmericanoExplain()
    {
        Back.SetActive(true);
        Americano.SetActive(true);
    }
    public void CafeMochaExplain()
    {
        Back.SetActive(true);
        CafeMocha.SetActive(true);
    }
    public void CappuchinoExplain()
    {
        Back.SetActive(true);
        Cappuchino.SetActive(true);
    }
    public void VanillaLatteExplain()
    {
        Back.SetActive(true);
        VanillaLatte.SetActive(true);
    }
    public void CafeLatteExplain()
    {
        Back.SetActive(true);
        CafeLatte.SetActive(true);
    }
    public void GreenteaLatteExplain()
    {
        Back.SetActive(true);
        GreenteaLatte.SetActive(true);
    }
    public void StrawberryLatteExplain()
    {
        Back.SetActive(true);
        StrawberryLatte.SetActive(true);
    }
    public void ChocoExplain()
    {
        Back.SetActive(true);
        Choco.SetActive(true);
    }
    public void SmoothieExplain()
    {
        Back.SetActive(true);
        Smoothie.SetActive(true);
    }
    public void BubbleteaExplain()
    {
        Back.SetActive(true);
        BubbleTea.SetActive(true);
    }
    public void FrappuccinoExplain()
    {
        Back.SetActive(true);
        Frappuccino.SetActive(true);
    }

    public void ManualEnd() //?????? ?? ????????
    {
        Back.SetActive(false);
        Espresso.SetActive(false);
        CaramelMacchiato.SetActive(false);
        Americano.SetActive(false);
        CafeMocha.SetActive(false);
        Cappuchino.SetActive(false);
        VanillaLatte.SetActive(false);
        CafeLatte.SetActive(false);
        GreenteaLatte.SetActive(false);
        StrawberryLatte.SetActive(false);
        Choco.SetActive(false);
        Smoothie.SetActive(false);
        BubbleTea.SetActive(false);
        Frappuccino.SetActive(false);

    }

}
