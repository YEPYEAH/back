# Git push --force и git rebase master или как уничтожить работу коллег
В нашем репозитории мы не используем разграничивающих политик, но убедительно просим всех, кто им пользуется, соблюдать установленные правила.

### Мы используем ***master-develop-taskbranch*** схему управления
#### Подключение к репозиторию
Чтобы подключиться к репозиторию, выберите подходящую папку и выполните в ней команду ***git clone https://github.com/Yayd/PFC*** . Войдите в скачавшуюся папку и выполните там команду ***git checkout develop*** и ***git push --set-upstream origin develop***. Теперь вы можете работать с этим репозиторием.
#### Внесение новых фич
Для того чтобы внести изменения в существующий проект, необходимо создать отдельную ветку от ветки ***develop***, в которой проделать все изменения в проекте. Затем эту ветку необходимо запушить в репозиторий. Если вы считаете что поставленная задача выполнена, перейдите на ветку ***develop*** на странице github и создайте *pull request* с требованием *code review*.
После чего добавьте ваш бренч в карточку трелло, а саму карточку перенесите в блок *Needs test*. Поздравляем! Вам осталось только подождать пока другой разработчик оценит ваш вклад в работу и подтвердит реквест. После подтверждения не удаляйте ветку разработки - мы не используем тегирование, но нам важно сохранять какую-никакую версионность.
#### Фикс на мастер
Для того чтобы внести изменения в мастер, необходимо перейти на ветку ***maser*** и от неё создать новый бренч hotfix-<название фикса>. В этой ветке можно внести изменения в мастер, запушить её в удаленный репозиторий и отправить реквест, который в дальнейшем должен подтвердить другой разработчик.
#### Неучтенные ситуации
Во всех остальных случаях, если вы не уверены в том что делаете, посоветуйтесь с кем-нибудь из команды.

### Основные команды git: (которые вам точно пригодятся)
***git init*** - создать репозиторий<br/>
***git remote add origin <URL удаленного репозитория>*** - подключить удаленный репозиторий к локальному<br/>
***git add .*** - добавить все файлы измененные файлы в следующий коммит<br/>
***git commit -m "описание коммита"*** - выполнить коммит<br/>
***git pull origin <ваша ветка>*** - обновить ваши локальные файлы в выбранной ветке<br/>
***git push origin <ваша ветка>*** - отправить все изменения на удаленный репозиторий<br/>
***git checkout -b <новая ветка>*** - ответвиться от существующей ветки в новую (существующую ветку можно узнать командой ***git status***)<br/>
***git checkout <ветка>*** - перейти на выбранную ветку<br/>
***git status*** - получить информацию о состоянии локального репозитория<br/>
