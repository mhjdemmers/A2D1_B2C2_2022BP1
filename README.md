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

### Om te beginnen
1.  Maak een fork van de repository door rechtsboven op de knop "Fork" te klikken en de stappen te doorlopen. Je hebt nu een kopie gemaakt van de repository in je eigen Github account.
2.  Haal de code binnen in Visual Studio door op "Code" > "Open in Visual Studio" te klikken.
3.  Bekijk de code op basis van bovenstaande uitleg. Zorg dat je snapt welke componenten er zijn en hoe het werkt. Voer de console applicatie uit en kijk of alles naar wens werkt.

### Maak de API
Zie ook het filmpje
1. Maak een nieuw project in je solution. Kies voor "ASP.NET Core Web API". Let op dat je C# kiest! Geef het project een passende naam, bijvoorbeeld "ToDoAPI". Verander niets aan de standaard instellingen voor het project. 
2. Zoek in je solution het nieuwe project op en klik met je rechtermuisknop. Kies voor "Set as startup project". Als de oplossing nu gestart wordt, zal dit het project zijn wat wordt uitgevoerd. De API zal dus starten. Valideer of dit gebeurt.

## Verder lezen
- Json: https://www.json.org/json-en.html
- Interface: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
- Singleton pattern: https://en.wikipedia.org/wiki/Singleton_pattern
- Fork: https://docs.github.com/en/get-started/quickstart/fork-a-repo

