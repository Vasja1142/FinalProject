# FinalProject
Данная работа является проверкой уровня знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Надеюсь вы убедитесь что мое базовое знакомство с it прошло успешно.
В данной работе я:
1. Создал репозиторий на GitHub
2. Нарисовал блок-схему алгоритма
3. Снабдил репозиторий оформленным текстовым описанием решением
4. Написал программу, решающую поставленную задачу
5. Использовал контроль версий в работе над этим небольшим проектом

Решалась задача по написанию программы которая из имеющегося массива строк формировала бы массив из строк, длинна которых меньше либо равна 3-м символам. Первоначальный массив можно внести с клавиатуры, либо задать на старте выполнения алгоритма. При решении задачи не рекомендовалось пользоваться коллекциями.

### Этапы создания программы:
1. Первоначально, я создал блок-схему, где определился с алгоритмом моей будущей программы
2. После, создал проект в .NET коммандой в консоли *dotnet new console*
3. Далее, на языке С#, я написал функцию FillArray, в которой создается массив строк введенных пользователем
4. После, написал вторую функцию, в которой и происходит основная магия. В данной функции, сначала, подсчитывается количество элементов массива длинна которых, меньше либо равна 3-м символам. Затем, создается массив с длинной равной этому количеству, и заполняется элементами массива, длинна которых меньше либо равна 3-м символам.
5. И в конце вызываем эти функции и выводим массивы в консоль.
