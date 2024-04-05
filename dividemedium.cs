using UnityEngine;
using TMPro;
using System;

public class DivideMedium : MonoBehaviour
{
    public TMP_Text mathProblemText;
    public TMP_InputField answerInputField;
    public TMP_Text resultText;
    public TextMeshProUGUI correctAnswersText;
    
    private int dividend;
    private int divisor;
    private int correctAnswers = 0;

    // ���������� ��� ������ ����
    void Start()
    {
        GenerateMathProblem();
        UpdateCorrectAnswersText();
    }

    // ���������� ����� �������������� ������
    private void GenerateMathProblem()
    {
        // ���������� ��� ��������� �����
        System.Random random = new System.Random();
        int num1 = random.Next(3, 15);
        int num2 = random.Next(3, 6);
        dividend = num1 * num2;
        divisor = num1;

        // ������� ������ �� �����
        mathProblemText.text = dividend + " / " + divisor + " = ?";
    }

    // ���������� ��� ������� �� ������ "���������"
    public void CheckAnswer()
    {
        int answer;

        // �������� ������������� ��������� ������������� ������ � �����
        if (!int.TryParse(answerInputField.text, out answer))
        {
            resultText.text = "Incorrect(";
            return;
        }

        // ��������� ����� ������������
        if (answer == dividend / divisor)
        {
            resultText.text = "Correct!";
            correctAnswers++;
            UpdateCorrectAnswersText();
        }
        else
        {
            resultText.text = "Incorrect, answer is: " + (dividend / divisor);
        }

        // ���������� ����� ������
        GenerateMathProblem();
        answerInputField.text = "";
    }
    // ��������� ��������� ���� � ����������� ���������� �������
    private void UpdateCorrectAnswersText()
    {
        correctAnswersText.text = "Score: " + correctAnswers;
    }
}
