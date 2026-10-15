
namespace id2;

/// <summary>
/// Лучник — персонаж, стреляющий из лука, способный лечиться.
/// </summary>
public class Archer : Character, IHealable
{
private int _arrowCount;

/// <summary>
/// Количество стрел в колчане.
/// </summary>
public int ArrowCount
{
    get => _arrowCount;
    set => _arrowCount = value;
}

/// <summary>
/// Признак того, что у лучника закончились стрелы.
/// </summary>
public bool IsOutOfArrows => ArrowCount <= 0;

/// <summary>
/// Инициализирует нового лучника с указанными параметрами.
/// </summary>
/// <param name="id">Уникальный идентификатор.</param>
/// <param name="name">Имя.</param>
/// <param name="health">Здоровье.</param>
/// <param name="arrowCount">Количество стрел.</param>
public Archer(int id, string name, int health, int arrowCount) : base(id, name, health)
{
    _arrowCount = arrowCount;
    Class = CharacterClass.Archer;
}

/// <summary>
/// Инициализирует нового лучника со значениями по умолчанию: health = 90, arrowCount = 20.
/// </summary>
/// <param name="name">Имя.</param>
public Archer(string name) : this(0, name, 90, 20)
{
}

/// <summary>
/// Лучник стреляет из лука, если есть стрелы.
/// </summary>
public override void Attack()
{
    if (IsOutOfArrows)
    {
        Console.WriteLine($"{Name} has no arrows left.");
        return;
    }

    ArrowCount--;
    Console.WriteLine($"{Name} shoots an arrow.");
}

/// <summary>
/// Восстанавливает здоровье лучника, если он жив.
/// </summary>
/// <param name="amount">Количество восстанавливаемых очков здоровья.</param>
public void Heal(int amount)
{
    if (!IsAlive)
    {
        Console.WriteLine($"{Name} cannot be healed.");
        return;
    }

    Health += amount;
    Console.WriteLine($"{Name} healed by {amount}.");
}

/// <summary>
/// Возвращает строковое представление лучника с учётом стрел.
/// </summary>
/// <returns>Строка с описанием персонажа.</returns>
public override string ToString()
{
    return $"[{Class}] {Name}, HP={Health}, class: {Class}, arrows={ArrowCount}\n" +
           $"  alive: {IsAlive}, out of arrows: {IsOutOfArrows}";
}
}