# DatabaseExercises

## EntityFrameworkCore
安裝EntityFrameworkCore必要套件
```csharp
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="3.1.7" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="3.1.7">
    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    <PrivateAssets>all</PrivateAssets>
</PackageReference>
```

## SQL Server
安裝SQL Server用的EF Core套件
```csharp
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.7" />
```

## Dapper
安裝Dapper用來查詢資料用
```
<PackageReference Include="Dapper" Version="2.0.90" />
```