# Итоговая работа

**Задача:** Написать программу, которая из имеющегося массива из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Блок-схема  

<image src="schema.png" alt="Схема" width=450>

---

## Решение
1. Вводим массив строк array
2. Объявляем переменные i и j, нужные для обращения к массивам в цикле и создаем результирующий массив resultArray.
3. Пока не дошли до конца изначального массива, проверяем каждый элемент массива: если длина элемента массива меньше или равна 3, то записывавем этот элемент в результирующий массив и инкрементируем счетчик j.
4. Выводим результирущий массив resultArray.