namespace id2;

/// <summary>
/// Точка входа в приложение. Демонстрирует полиморфизм, работу с интерфейсами и паттерн-матчинг.
/// </summary>
public class Program
{
    /// <summary>
    /// Запускает демонстрацию игровых персонажей.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    public static void Main(string[] args)
    {
        List<Character> characters = new List<Character>
        {
            new Warrior("Conan"),
            new Mage("Merlin"),
            new Archer("Robin")
        };

        foreach (Character character in characters)
        {
            Console.WriteLine(character);
            character.Attack();

            if (character is IHealable healable)
            {
                healable.Heal(50);
            }
            else
            {
                Console.WriteLine($"{character.Name} cannot be healed.");
            }
        }
    }
}