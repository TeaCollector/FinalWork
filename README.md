## FinalWork for developer

In this page I will resolve the task.

## Опишу порядок выполнения:
  1. С начала проанализировал задачу как лучше всего решить, пришел к выводу что не буду переживать по поводу создания двух циклов, и использования двух массив, т. к. в задаче не было ограничений на количество используемой памяти и скорости выполнения.
  2. Создал метод который принимает на вход число(n), которое будет означать размер массива строк, и которое будет вводить пользователь, так же, метод будет возвращать массив строк.
  3. Создал два массива, один проинициализирован сразу же, а второй будет позже, когда выяснить сколько пользователь всего ввел строк длиной меньше либо равно 3.
  4. Обьявил переменные типа int и назвал их i и j, i - отвечает на количество циклов while, а j за заполнение первого массива по порядку от начала, чтобы у нас не возникло такой ситуации, что нужный строка стояла в конце, и было куча незаполненных ячеек в массиве.
  5. Объявил цикл while с условием пока i < n, и на каждой итерации пользователю предлагаю ввести строку.
  6. Далее, если строка соответствует нашему условию (имеет 3 и менее символа) она записывается в первый массив с индексом j (j при этом инкрементируется), если не соответствует условию то просто итерируемся дальше.
  7. Наконец, когда итерации закончена, у нас есть определенное количество нужных нам строк (переменная j), и массив в котором содержаться эти строки.
  8. Далее мы обнуляем счетчик и инициализируем второй массив длиной j.
  9. И в финале просто переписывает все эелемента из первого массива во второй(с помощью цикла while(i < j)), дабы массив содержал только нужное количество строк, и не было в принципе лишнего пространства
  10. Возвращаем второй массив и радуемся решенной задаче.

<details><summary><h2>Здесь находится ссылка на диаграмму</h2></summary>

 Its a reference for [diagramm](https://drive.google.com/file/d/1F9MseT2WGazjMLRxlXCJ6iVtOBodYcWh/view?usp=sharing).

</details>
