# A2D1_B2C2_2022BP1
Deze repository wordt gebruikt om een aantal voorbeelden te delen voor de vakken A2D1 en B2C2 (Web development).

# API: ToDoList
In de map ToDOList is een eenvoudige applicatie te vinden. Met deze applicatie is het mogelijk een ToDoList bij te houden. De applicatie is ontwikkeld in .NET core 6.0. Dit is een voorbeeld van hoe een applicatie eruit zou kunnen zien in lagen. 

## Uitleg bestaande appplicatie
### DataLayer
De data wordt momenteel opgeslagen in een tekstbestand in json formaat. Dit is een eenvoudig opslagmechanisme en niet geschikt voor multithreading of complexe relaties zoals wel kan bij een RMDB. Voor dit voorbeeld volstaat dit. De daadwerkelijke DAL is de JsonDAL. Hierin zijn alle CRUD operaties naar de file geimplementeerd.
De json file wordt automatisch opgeslagen in je bin folder. Indien de file niet wordt gevonden, wordt dummy data aangemaakt. Wil je je data resetten, gooi dan de file gewoon weg.

Naast de DAL is er een IDataAccessLayer interface. Deze is gemaakt om in de toekomst mogelijk andere DALs te implementeren. Stel je wilt een MSSQL Dal gaan maken dan kun je dat doen op basis van de interface. Er is een DALSingleton class welke, volgens het singleton pattern, ervoor zorgt dat je je DAL niet telkens opnieuw hoeft aan te maken.

### Models
Hierin staat de enige entiteit van deze applicatie. Het is een class uitgewerkt met properties en methods. De methods (gedrag) van de class beïnvloeden de properties (status). In je eigen applicatie zou dit ook zo uit moeten zien.

### Program.cs
Dit is het programma wat momenteel alle CRUD operaties een keer uitvoert.


## Opdracht
Het is de bedoeling om voor deze bestaande applicatie een API te maken. Om dit te doen voer je de volgende stappen uit. 
1.  fdgfg


## Verder lezen
- Json: https://www.json.org/json-en.html
- Interface: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
- Singleton pattern: https://en.wikipedia.org/wiki/Singleton_pattern

