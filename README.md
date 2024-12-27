
# Garbage Collector Simulator Documentation

## Overview

This console application simulates the behavior of a garbage collector in .NET, showcasing how objects are allocated and managed across three generations: Generation 0, Generation 1, and Generation 2. It demonstrates the importance of understanding memory management for optimizing application performance.

---

### Why Is It Important to Understand Garbage Collector Generations?

Understanding how the garbage collector works allows developers to write more efficient and optimized applications. Mismanagement of memory can lead to performance degradation, application crashes, or memory leaks. Knowing how memory generations operate helps in:

- **Minimizing memory footprint**: Short-lived objects are quickly collected, while long-lived objects are stored efficiently.
- **Avoiding unnecessary promotions**: Reducing the cost of moving objects between generations.
- **Improving application performance**: By designing objects and memory usage patterns that align with the garbage collector's logic.

---

## English (EN)

### Features:

#### Generation 0 (Short-lived Objects)
- **Description**: Represents short-lived objects. These are quickly created and discarded.
- **Code Reference**: `CreateGeneration0Garbage` method.

```csharp
static void CreateGeneration0Garbage()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Creating Generation 0 garbage...");
    for (int i = 0; i < 100; i++)
    {
        var garbage = new object(); // Creates short-lived objects
    }
    Console.WriteLine("Generation 0 garbage created and discarded.");
    Console.ResetColor();
}
```

#### Generation 1 (Medium-lived Objects)
- **Description**: Represents objects that survive at least one garbage collection cycle.
- **Code Reference**: `CreateGeneration1Garbage` method.

```csharp
static void CreateGeneration1Garbage()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Creating Generation 1 garbage...");
    var generation1Garbage = new List<object>();
    for (int i = 0; i < 10; i++)
    {
        generation1Garbage.Add(new object()); // Objects retained temporarily in memory
    }

    Console.WriteLine("Forcing garbage collection to promote Generation 1 objects...");
    GC.Collect(); // Force garbage collection to promote objects
    GC.WaitForPendingFinalizers();

    Console.WriteLine("Generation 1 garbage created and promoted temporarily.");
    Console.ResetColor();
}
```

#### Generation 2 (Long-lived Objects)
- **Description**: Represents long-lived objects.
- **Code Reference**: `CreateGeneration2Garbage` method.

```csharp
static void CreateGeneration2Garbage()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Creating Generation 2 garbage...");
    for (int i = 0; i < 5; i++)
    {
        Generation2Objects.Add(new object()); // Simulate long-lived objects by retaining them in a static list
    }
    Console.WriteLine("Generation 2 garbage created and retained long-term.");
    Console.ResetColor();
}
```

---

## Español (ES)

### Características:

#### Generación 0 (Objetos de corta duración)
- **Descripción**: Representa objetos de corta duración. Se crean y descartan rápidamente.
- **Referencia de código**: Método `CreateGeneration0Garbage`.

```csharp
static void CreateGeneration0Garbage()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Creando basura de Generación 0...");
    for (int i = 0; i < 100; i++)
    {
        var garbage = new object(); // Crea objetos de corta duración
    }
    Console.WriteLine("Basura de Generación 0 creada y descartada.");
    Console.ResetColor();
}
```

#### Generación 1 (Objetos de duración media)
- **Descripción**: Representa objetos que sobreviven al menos un ciclo de recolección de basura.
- **Referencia de código**: Método `CreateGeneration1Garbage`.

```csharp
static void CreateGeneration1Garbage()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Creando basura de Generación 1...");
    var generation1Garbage = new List<object>();
    for (int i = 0; i < 10; i++)
    {
        generation1Garbage.Add(new object()); // Objetos retenidos temporalmente en memoria
    }

    Console.WriteLine("Forzando recolección de basura para promover objetos de Generación 1...");
    GC.Collect(); // Fuerza la recolección de basura para promover objetos
    GC.WaitForPendingFinalizers();

    Console.WriteLine("Basura de Generación 1 creada y promovida temporalmente.");
    Console.ResetColor();
}
```

#### Generación 2 (Objetos de larga duración)
- **Descripción**: Representa objetos de larga duración.
- **Referencia de código**: Método `CreateGeneration2Garbage`.

```csharp
static void CreateGeneration2Garbage()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Creando basura de Generación 2...");
    for (int i = 0; i < 5; i++)
    {
        Generation2Objects.Add(new object()); // Simula objetos de larga duración retenidos en una lista estática
    }
    Console.WriteLine("Basura de Generación 2 creada y retenida a largo plazo.");
    Console.ResetColor();
}
```

---

## Français (FR)

### Fonctionnalités :

#### Génération 0 (Objets de courte durée)
- **Description** : Représente des objets de courte durée. Ils sont rapidement créés et supprimés.
- **Référence de code** : Méthode `CreateGeneration0Garbage`.

```csharp
static void CreateGeneration0Garbage()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Création des déchets de Génération 0...");
    for (int i = 0; i < 100; i++)
    {
        var garbage = new object(); // Crée des objets de courte durée
    }
    Console.WriteLine("Déchets de Génération 0 créés et supprimés.");
    Console.ResetColor();
}
```

#### Génération 1 (Objets de durée moyenne)
- **Description** : Représente des objets qui survivent à au moins un cycle de collecte de déchets.
- **Référence de code** : Méthode `CreateGeneration1Garbage`.

```csharp
static void CreateGeneration1Garbage()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Création des déchets de Génération 1...");
    var generation1Garbage = new List<object>();
    for (int i = 0; i < 10; i++)
    {
        generation1Garbage.Add(new object()); // Objets conservés temporairement en mémoire
    }

    Console.WriteLine("Forçage de la collecte des déchets pour promouvoir les objets de Génération 1...");
    GC.Collect(); // Forcer la collecte des déchets pour promouvoir les objets
    GC.WaitForPendingFinalizers();

    Console.WriteLine("Déchets de Génération 1 créés et temporairement promus.");
    Console.ResetColor();
}
```

#### Génération 2 (Objets de longue durée)
- **Description** : Représente des objets de longue durée.
- **Référence de code** : Méthode `CreateGeneration2Garbage`.

```csharp
static void CreateGeneration2Garbage()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Création des déchets de Génération 2...");
    for (int i = 0; i < 5; i++)
    {
        Generation2Objects.Add(new object()); // Simule des objets de longue durée retenus dans une liste statique
    }
    Console.WriteLine("Déchets de Génération 2 créés et conservés à long terme.");
    Console.ResetColor();
}
```

---
