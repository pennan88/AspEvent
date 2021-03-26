ASP.net är för att skapa webbapplikationer, detta kan göras med bland annat, Razor pages eller MVC

Startup.cs går genom vilka steg som krävs för att en sida skall kunna skicka tillbaka 200 OK, det finns en del steg som man själv har kontroll att styra över, 
så som ifall användaren har tillåtelse att få tillgång till sidan

Wwwroot hanterar dina statiska filer, såsom CSS, JS eller bilder som används genom ditt projekt i asp net.

Razor-språket gör så att en kan slå ihop HTML sida med C#-kod, där man kan genom @-tag skriva ”server kod” som är vanlig C# kod i ett HTML dokument

RazorPages ger dig en möjlighet att lägg in c# kod i ditt html-dokument, där varje content page får en page model sida, detta gör så det kan bli enklare att skriva get/post 
calls eller skapa kommunikationer med en databas.

MVC står för Model View Controller.

Model = sköter datahantering som den får från en databas.
View = Det visuella som användaren kan se och även ha möjlighet att förändra
Controller = Hanterar en  användares request, det fungerar genom att en användare som är en View skickar en request som en kontrollen hanterar och ger en respons tillbaka



