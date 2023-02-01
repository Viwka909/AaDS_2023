# Курс по Алгоритмам и структурам данных

## Структура репозитория

`Lessons` - В данной директории хранится код с занятий</br>
`Tasks` - В данной директории хранится код для выполнения заданий курса</br>

## Сдача заданий

### Начало работы

1. Сделать `fork` репозитория
2. Склонировать `fork` репозитория

    ```
    git clone https://github.com/<your username>/ITHUB_AaDS_2023.git
    ```
3.  Перейти в директорию

    ```
    cd  ITHUB_AaDS_2023
    ``` 
4. Синхронизировать `fork` с репозиторием курса

    ```
     git remote add upstream https://github.com/Badcat330/ITHUB_AaDS_2023.git
    ```
4. Вывести `remote`

    ```
    git remote -v
    ```
 
5. Запретить `push` в репозиторий курса

    ```
    git remote set-url --push upstream no_push
    ```

6. Сверить вывод в терминале

    ```
    origin  https://github.com/<your username>/ITHUB_AaDS_2023.git (fetch)
    origin  https://github.com/<your username>/ITHUB_AaDS_2023.git (push)
    upstream        https://github.com/Badcat330/ITHUB_AaDS_2023.git (fetch)
    upstream        no_push (push)
    ```

## Работа в репозитории
1. Из `master` ветки создать ветку под задачу

    ```
    git checkout -b <название задачи>
    ```
2. Перейти в директорию с задачей

    Пример: `Tasks/Task1/DynamicArrays`
3. Прочитать условие задачи `task.md`
4. Написать решение задачи 
5. Протестировать решение
    Пример: `dotnet test DynamicArrayTest/DynamicArrayTest.csproj`
6. Отфарматировать код запустив команду `dotnet format` в папке с вашим решением
7. Добавить файлы на удаленный репозиторий

    ```
    git add .
    git commit -m "ваше сообщение"
    git push
    ```
8. После выполнения задания сделать `PR` в `master`

`Замечание:` ветка с задачей не будет вливаться в `master` ветку

## Подкачивание изменений из основного репозитория

1. В любой папке директории выполнить:

    ```
    git fetch upstream
    ```
2. Перейти в `master` ветку на локали

    ```
    git checkout master
    ```
3. Подкачать измения из `master` ветки репозитория курса

    ```
    git merge upstream/master master
    ```
4. Приступить к решению новой задачи

## Если Вы изменили master в fork

1. Перейти в `master`

    ```
    git checkout master
    ```
2. Подкачать обновления с репозитория курса
    
    ```
    git fetch upstream
    ```
3. Перейти к актуальному `master`
    
    ```
    git reset --hard upstream/master
    ```

4. Переписать изменения в `fork`

    ```
    git push -f
    ```