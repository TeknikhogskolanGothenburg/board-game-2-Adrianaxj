Put the documentation of the board game here

The run the documentation you can see the content of this by opening commandline and navigate to the DocsSrc folder, and write ```docfx .\docfx.json --serve --port 8081```, then open your browser and navigate to [localhost:8081](http://localhost:8081).

GameBoardViewModel = G�r till HomeControllen
D�r har jag lagt en klass som inneh�ller spelare, nuvarandespelar samt en lista p� spelplanen

GameEngine: 
Player = Om spelare som har en Id & en SessionId 

GameEngine = D�r finns en lista p� spel plan - Square och Player Listan 

GetPlayer = D�r har vi spelare 1 eller 2 och deras SessionId 

PlayerLeave = Beroende p� vilken SessionId spelar har som l�mnar spelet

MakeMove = �r en metod som tar in spelaren och vilken position p� br�det. Metoden kollar om det �r spelarens tur och om positionen �r ledig p� br�det.

HasWon = Beror p� Om X eller O har vunnit tre i rad.
Jag har kodat s� att spelare 1 och spelare 2 kan vinna 3 p� raken.
I lodr�tt 0-1-2 , 3-4-5, 6-7-9.
V�gr�tt 0-3-6, 1-4-7, 2-5-8,
Diagonalt 0-4-8 

Index:
H�r finns koden f�r veta vems tur det �r att spela s� f�r du ett meddelande d�r de st�r din tur eller inte din tur. 
Samt en knapp d�r du kan trycka p� f�r l�mna spelet 

About:
ViewBag f�r Titel och Massage

GameLeft: 
D�r finns det bara ett meddelande d�r de st�r att spelaren har l�mnat spelet

GameFull:
Att de fullt med spelare






