# Proyecto C# - Sistema de Personajes

Este proyecto en C# implementa un sistema de personajes que incluye clases para personajes, armas, armaduras y minions.

## Diagrama de Clases

A continuación se muestra el diagrama de clases del sistema:

![Diagrama de Clases](C:\Users\Josue\Desktop\Proyectos\Practica1-main\resources\DiagramaDeClases.png)

## Clases Principales

### 1. Character
- **Propiedades:**
    - `string Name`
    - `int MaxHitPoints`
    - `int CurrentHitPoints`
    - `int BaseDamage`
    - `int BaseArmor`
    - `List<IApply> Inventory`
    - `List<Minion> Minions`
- **Métodos:**
    - `int Attack()`
    - `int Defense()`
    - `void Heal(int amount)`
    - `void ReceiveDamage(int damage)`
    - `void AddToInventory(IApply item)`
    - `void InvokeMinion()`

### 2. IApply (Interfaz)
- **Métodos:**
    - `void Apply(Character character)`

### 3. Protection (Clase Abstracta)
- **Propiedades:**
    - `string Name`
    - `int Armor`
- **Métodos:**
    - `abstract void Apply(Character character)`

### 4. Shield (Hereda de Protection)
- **Constructor:**
    - `Shield(string name, int armor)`
- **Métodos:**
    - `override void Apply(Character character)`

### 5. Weapon (Clase Abstracta)
- **Propiedades:**
    - `string Name`
    - `int Damage`
- **Métodos:**
    - `abstract void Apply(Character character)`

### 6. Sword (Hereda de Weapon)
- **Constructor:**
    - `Sword(string name, int damage)`
- **Métodos:**
    - `override void Apply(Character character)`

### 7. Minion
- **Propiedades:**
    - `string Name`
    - `int MaxHitPoints`
    - `int CurrentHitPoints`
    - `int BaseDamage`
    - `int BaseArmor`
- **Métodos:**
    - `int Attack()`
    - `int Defense()`


