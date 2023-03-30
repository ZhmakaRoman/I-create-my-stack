using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Task
    {
        static void Main(string[] args)
        {
            // Создаем стек.
            var stack = new Stack(); 
            
            // Добавляем четыре элемента в стек.
            stack.Push(new Person("Kate", 24));
            stack.Push(new Person("Sam", 19));
            stack.Push(new Person("Alice", 30));
            stack.Push(new Person("Tom", 10));

            // Извлекаем один элемент из стека.
            var element = stack.Pop();
            Console.WriteLine(element.Name); 
            
            // Получаем верхушку стека без извлечения.
            element = stack.Peek();
            Console.WriteLine(element.Name); // Alice
            
            // Получаем верхушку стека без извлечения.
            element = stack.Peek();
            Console.WriteLine(element.Name); // Alice

            // Пересоздаем стек элемент. 
            stack = new Stack();
            element = stack.Pop(); // Стек пуст, так как в него ничего не добавили.
            element = stack.Peek(); // Стек пуст, так как в него ничего не добавили.
        }
    }

    /// <summary>
    /// Класс, представляющий структуру данных Stack.
    /// </summary>
    public class Stack
    {
        private List<Person> _items = new(4); // Массив элементов стека.
        private int _count; // Счетчик элементов стека.

        /// <summary>
        /// Метод добавляет элемент в стек.
        /// </summary>
        public void Push(Person item)
        {
            // Добавляем элемент в массив:
            // Если под индексом _count уже есть элемент.
            // Такая ситуация произойдет после вызова метода Pop, в котором мы просто уменьшаем сцетчик элементов на 1
            if (_count < _items.Count && _items[_count] != null)
            {
                // Перезаписываем его
                _items[_count] = item;
            }
            else
            {
                // Иначе - добавляем элементв конец динамического массива.
                _items.Add(item);
            }
            
            //Увеличиваем счетчик элементов
            _count++;
        }

        /// <summary>
        /// Метод извлекает элемент из стека и возвращает его.
        /// Если стек пуст, возвращает null и выводит на консоль "The stack is empty"
        /// </summary>
        public Person Pop()
        {
            // Проверяем, пустой ли стек.
            if (_count > 0)
            {
                // Возвращаем верхнее значение стека и уменьшаем счетчик элементов.
                return _items[--_count];
            }
            
            // Если стек пустой, выводим "Stack is empty" на консоль.
            Console.WriteLine("Stack is empty");
            
            // Возвращаем null.
            return null;
        }

        /// <summary>
        /// Метод возвращает элемент из стека БЕЗ извлечения.
        /// Если стек пуст, возвращает null и выводит на консоль "The stack is empty"
        /// </summary>
        public Person Peek()
        {
            // Проверяем, пустой ли стек.
            if (_count > 0)
            {
                // Возвращаем верхнее значение стека.
                return _items[_count - 1];
            }

            // Если стек пустой, выводим "Stack is empty" на консоль.
            Console.WriteLine("Stack is empty");
            
            // Возвращаем null.
            return null;
        }
    }
    
    /// <summary>
    /// Элемент стека.
    /// </summary>
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}