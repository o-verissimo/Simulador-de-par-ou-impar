using UnityEngine;
using UnityEngine.UI;

public class impar_par : MonoBehaviour
{
    int soma;
    public InputField nome_jgd_1;
    public InputField num_jgd_1;
    public InputField escolha_jgd_1;
    public Text resultado;
    public Text nome_jgd_2;
    public Text num_jgd_2;

    int num_jd_1;
    int num_jd_2;
    string escolha_jd_1;
    string nome_jd_1;
    string nome_jd_2;



    void PuxarDados()
    {

        num_jd_1 = int.Parse(num_jgd_1.text);

        num_jd_2 = Random.Range(0, 11);

        num_jgd_2.text = num_jd_2.ToString();

        nome_jd_1 = nome_jgd_1.text;

        nome_jd_2 = nome_jgd_2.text;

        
    }

    public void jogar()
    {
        if (escolha_jgd_1.text == "par" || escolha_jgd_1.text == "impar")
        {
            escolha_jd_1 = escolha_jgd_1.text;
        }
        else
        {
            resultado.text = "ESCOLHA ENTRE IMPAR OU PAR";
            num_jgd_2.text = "Número...";
            return;
        }

        PuxarDados();

        soma = num_jd_1 + num_jd_2;

        if ( soma % 2 == 0 && escolha_jd_1 == "par")
        {
            resultado.text = $"{soma.ToString()} É UM NÚMERO PAR, PORTANTO {nome_jd_1} VENCEU!";
        }

        if (soma % 2 == 0 && escolha_jd_1 == "impar")
        {
            resultado.text = $"{soma.ToString()} É UM NÚMERO PAR, PORTANTO {nome_jd_2} VENCEU!";
        }

        if (soma % 2 == 1 && escolha_jd_1 == "par")
        {
            resultado.text = $"{soma.ToString()} É UM NÚMERO IMPAR, PORTANTO {nome_jd_2} VENCEU!";
        }

        if (soma % 2 == 1 && escolha_jd_1 == "impar")
        {
            resultado.text = $"{soma.ToString()} É UM NÚMERO IMPAR, PORTANTO {nome_jd_1} VENCEU!";
        }

    }

}
