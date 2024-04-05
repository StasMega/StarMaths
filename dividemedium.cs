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
        int num1 = random.Next(3, 15);
        int num2 = random.Next(3, 6);
        dividend = num1 * num2;
        divisor = num1;

        // Выводим пример на экран
        mathProblemText.text = dividend + " / " + divisor + " = ?";
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
