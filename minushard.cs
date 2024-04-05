using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class MinusMedium : MonoBehaviour
{
    public TMP_Text mathProblemText;
    public TMP_InputField answerInputField;
    public TMP_Text resultText;
    public TMP_Text correctAnswersText;

    private int number1;
    private int number2;
    private int correctAnswers = 0;

    // Вызывается при старте игры
    void Start()
    {
        GenerateMathProblem();
        UpdateCorrectAnswersText();
    }

    // Генерирует новый математический пример
    private void GenerateMathProblem()
    {
        // Генерируем два случайных числа
        System.Random random = new System.Random();
        number1 = random.Next(30, 70);
        number2 = random.Next(30, number1 + 5);

        // Выводим пример на экран
        mathProblemText.text = number1 + " - " + number2 + " = ?";
    }

    // Вызывается при нажатии на кнопку "Проверить"
    public void CheckAnswer()
    {
        int answer;

        // Пытаемся преобразовать введенную пользователем строку в число
        if (!int.TryParse(answerInputField.text, out answer))
        {
            resultText.text = "Incorrect(";
            return;
        }

        // Проверяем ответ пользователя
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

        // Генерируем новый пример
        GenerateMathProblem();
        answerInputField.text = "";
    }

    // Обновляет текстовое поле с количеством правильных ответов
    private void UpdateCorrectAnswersText()
    {
        correctAnswersText.text = "Score: " + correctAnswers;
    }
}
