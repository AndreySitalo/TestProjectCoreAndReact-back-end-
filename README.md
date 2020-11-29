### Порядок действий для запуска сервиса
-Добавить в проект Orders.DB следующие nuget packeg(Microsoft.EntityFrameworkCore 3.1.10, Microsoft.EntityFrameworkCore.SqlServer 3.1.10,Microsoft.EntityFrameworkCore.Tools 3.1.10)

-Добавить в проект Orders.WebApi следующие nuget packeg(Microsoft.EntityFrameworkCore.Design)

-Перейти в консоли(PM) в проект Orders.DB 

-Выполнить ADD-MIGRATION initial-1

-Выполнить UPDATE-DATABASE

