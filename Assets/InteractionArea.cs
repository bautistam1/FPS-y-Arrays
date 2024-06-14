using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//detectar cuando el area entra en contacto con un alimento
//si lo hace destruyo el alimento y suma a una variable del alimento
//y muestra el valor de la variable en el txtscore de la escena

public class InteractionArea : MonoBehaviour
{
    public Text txtScore;
    public int score;
    public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        if (collision.gameObject.GetComponent<AlimentoScript>() != null)
        {
            Destroy(collision.gameObject);
        }
        score += alimento.valorAlimentario;
        txtScore.text = score.ToString();

        if (score >= maxScore)
        {
            txtScore.text = "¡Ganaste!";
        }
    }
   
}
