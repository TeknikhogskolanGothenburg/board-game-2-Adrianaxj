Put the documentation of the board game here

The run the documentation you can see the content of this by opening commandline and navigate to the DocsSrc folder, and write ```docfx .\docfx.json --serve --port 8081```, then open your browser and navigate to [localhost:8081](http://localhost:8081).

GameBoardViewModel = Går till HomeControllen
Där har jag lagt en klass som innehåller spelare, nuvarandespelar samt en lista på spelplanen

GameEngine: 
Player = Om spelare som har en Id & en SessionId 

GameEngine = Där finns en lista på spel plan - Square och Player Listan 

GetPlayer = Där har vi spelare 1 eller 2 och deras SessionId 

PlayerLeave = Beroende på vilken SessionId spelar har som lämnar spelet

MakeMove = Är en metod som tar in spelaren och vilken position på brädet. Metoden kollar om det är spelarens tur och om positionen är ledig på brädet.

HasWon = Beror på Om X eller O har vunnit tre i rad.
Jag har kodat så att spelare 1 och spelare 2 kan vinna 3 på raken.
I lodrätt 0-1-2 , 3-4-5, 6-7-9.
Vågrätt 0-3-6, 1-4-7, 2-5-8,
Diagonalt 0-4-8 

Index:
Här finns koden för veta vems tur det är att spela så får du ett meddelande där de står din tur eller inte din tur. 
Samt en knapp där du kan trycka på för lämna spelet 

About:
ViewBag för Titel och Massage

GameLeft: 
Där finns det bara ett meddelande där de står att spelaren har lämnat spelet

GameFull:
Att de fullt med spelare






