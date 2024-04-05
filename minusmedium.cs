using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class MinusHard : MonoBehaviour
{
    public TMP_Text mathProblemText;
    public TMP_InputField answerInputField;
    public TMP_Text resultText;
    public TMP_Text correctAnswersText;

    private int number1;
    private int number2;
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
        number1 = random.Next(5, 30);
        number2 = random.Next(1, number1 + 1);

        // ������� ������ �� �����
        mathProblemText.text = number1 + " - " + number2 + " = ?";
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
        if (answer == number1 - number2)
        {
            resultText.text = "Correct!";
            correctAnswers++;
            UpdateCorrectAnswersText();
        }
        else
        {
            resultText.text = "Incorrect, answer is: " + (number1 - number2);
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
