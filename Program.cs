using System;
using System.Linq;
using System.Collections.Generic;

class Model
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    // Конструктор класу
    public Model(string name, string lastName, int age, int height, int weight)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Height = height;
        Weight = weight;
    }
}

class Program
{
    static void Main()
    {
        // Створення колекції моделей
        List<Model> models = new List<Model>
        {
            new Model("Анна", "Іванова", 24, 176, 54),
            new Model("Марія", "Петренко", 22, 179, 52),
            new Model("Олена", "Сидорова", 26, 178, 58),
            new Model("Ірина", "Мельник", 23, 175, 53),
            new Model("Діана", "Коваленко", 25, 180, 50),
            new Model("Юлія", "Шевченко", 21, 177, 49),
            new Model("Вікторія", "Гриценко", 28, 172, 60),
            new Model("Анастасія", "Бондаренко", 24, 180, 55),
            new Model("Тетяна", "Черненко", 19, 173, 51),
            new Model("Катерина", "Федоренко", 22, 178, 53)
        };

        // Запит LINQ для фільтрації за віком, зростом та вагою
        var filteredModels = models
            .Where(model => model.Age <= 25 && model.Height >= 175 && model.Height <=

