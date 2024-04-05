using UnityEngine;
using TMPro;

public class MultiplyEasy : MonoBehaviour
{
    public TextMeshProUGUI mathProblemText;
    public TMP_InputField answerInputField;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI scoreText; // новый текстовый элемент UI для отображения количества правильных ответов
    public int minNumber = 0;
    public int maxNumber = 7;

    private int number1;
    private int number2;
    private int correctAnswers;

    // Вызывается при старте игры
    void Start()
    {
        GenerateMathProblem();
        UpdateScoreText(); // обновляем значение текстового элемента UI при старте игры
    }

    // Генерирует новый математический пример
    private void GenerateMathProblem()
    {
        // Генерируем два случайных числа
        number1 = Random.Range(minNumber, maxNumber + 1);
        number2 = Random.Range(minNumber, maxNumber + 1);

        // Выводим пример на экран
        mathProblemText.text = $"{number1} × {number2} = ?";
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
        if (answer == number1 * number2)
        {
            resultText.text = "Correct!";
            correctAnswers++;
            UpdateScoreText(); // обновляем значение текстового элемента UI при правильном ответе
        }
        else
        {
            resultText.text = $"Incorrect, answer is: {number1 * number2}";
        }

        // Генерируем новый пример
        GenerateMathProblem();
        answerInputField.text = "";
    }

    // Вызывается при нажатии на кнопку "Новая игра"
    public void NewGame()
    {
        GenerateMathProblem();
        answerInputField.text = "";
        resultText.text = "";
        correctAnswers = 0;
        UpdateScoreText(); // обновляем значение текстового элемента UI при начале новой игры
    }

    // Обновляет значение текстового элемента UI, отображающего количество правильных ответов
    private void UpdateScoreText()
    {
        scoreText.text = $"Score: {correctAnswers}";
    }
}
