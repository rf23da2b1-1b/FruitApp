// See https://aka.ms/new-console-template for more information
using FruitLib.model;
using FruitLib.repository;

Console.WriteLine("Hello, World!");

Fruit alm = new Fruit();
Fruit apple = new Fruit(5, "apple", 500, 21.5);

Console.WriteLine(alm);
Console.WriteLine(apple);


Console.WriteLine("===> Repository  <===");
IFruitRepository repo = new FruitRepository();
repo.Create(alm);
repo.Create(apple);

Console.WriteLine("create + readAll");
foreach (Fruit f in repo.ReadAll())
{
    Console.WriteLine(f);
}

Console.WriteLine("Update");
Fruit apple2 = new Fruit(5, "apple", 1000, 40);
Fruit updatedFruit = repo.Update(5, apple2);
Console.WriteLine(updatedFruit);

Console.WriteLine("read by id - exists");
Console.WriteLine(repo.ReadById(5));

Console.WriteLine("read by id - do not exists");
try
{
    Console.WriteLine(repo.ReadById(3));
}
catch(KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}

Console.WriteLine("delete by id - exists");
Console.WriteLine(repo.Delete(5));
Console.WriteLine("readAll after delete");
foreach (Fruit f in repo.ReadAll())
{
    Console.WriteLine(f);
}


/*
 * Generic
 */
Console.WriteLine("===> Generic Repository  <===");
IRepositoryGeneric<Fruit> repo2 = new RepositoryGeneric<Fruit>();
repo2.Create(alm);
repo2.Create(apple);

Console.WriteLine("create + readAll");
foreach (Fruit f in repo2.ReadAll())
{
    Console.WriteLine(f);
}

Console.WriteLine("Update");
Fruit apple22 = new Fruit(5, "apple", 1000, 40);
Fruit updatedFruit2 = repo2.Update(5, apple22);
Console.WriteLine(updatedFruit2);

Console.WriteLine("read by id - exists");
Console.WriteLine(repo2.ReadById(5));

Console.WriteLine("read by id - do not exists");
try
{
    Console.WriteLine(repo2.ReadById(3));
}
catch (KeyNotFoundException knfe)
{
    Console.WriteLine(knfe.Message);
}

Console.WriteLine("delete by id - exists");
Console.WriteLine(repo2.Delete(5));
Console.WriteLine("readAll after delete");
foreach (Fruit f in repo2.ReadAll())
{
    Console.WriteLine(f);
}
