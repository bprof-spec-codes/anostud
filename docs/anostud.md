# AnoStud - Szakmai hallgatói közösségépítésre szolgáló platform létrehozása

## Leírás

A feladat egy olyan platform létrehozása, ahol a hallgatók gamifikációs formában tudnak szakmaileg előremutató kapcsolatokat építeni, jelenlegi hallgatótársaikkal. Ezt anoním módon, egymást értékelve tudják megtenni.

### Működés

A rendszerbe központilag betöltésre kerül x db hallgatói profil pl. félév elején (ezek a profiladatok .csv formátumban legyenek megadhatóak). A hallgatók ezt követően ezen a platformon bejelentkezve tudják egymást böngészni és értékelést adni, anoním módon. Ez azt jelenti, hogy az értékelést adó hallgató kiléte titokban marad az értékelt hallgató irányába (mindaddig amíg az fel nem fedi azt, lásd lentebb).

### Böngésző nézet

A rendszerben legyen egy böngésző nézet, ahol a hallgatói profilok listázódnak. Egy profilt kiválasztva a hallgatót lehet értékelni pontszámokkal és szöveges leírással is. A feladat része egy rendszer kidolgozása, hogy itt milyen szempontok legyenek felsorolva az értékelés kapcsán (erről a véglegesítés előtt egyeztetés szükséges).

### Match-elés

A rendszer sajátossága, amire nagy hangsúlyt kell fektetni, hogy képes legyen arra, hogy a jó értékelést kapott hallgatók valamilyen módon kapcsolatba tudjanak kerülni (tehát a kilétük felfedődik) az őket pozitívan értékelőkkel. **A rendszer célja, hogy így az egymástól kapott elismerő szavakat akár valós szakmai közösségi profilokon is beválthatják pl. LinkedIn-en.**

A rendszer hívja fel a hallgatók figyelmét, hogy "Pozitív értékelést kaptál! Erősítsétek meg ezen elismerést LinkedIn-en keresztül is.", majd ezt követően ajánlja fel, hogy felfedheti a profilját annak az 1 hallgatónak akivel úgymond "match"-el. Ezt követően a rendszer dobjon fel egy linket, amin megerősítheti a szakmai elismerést a valós LinkedIn profilon is.

Fontos, hogy ez nem történhet automatikusan, csakis a hallgató beleegyezésével.

### Tinder-szerű gyorsértékelő nézet

A rendszerben legyen lehetőség Tinder-szerűen random profilokat kínálni a felhasználónak (ez független a böngésző nézettől). Ehhez dolgozzon ki egy algoritmust, amely valamilyen frappáns logika mentén kínál profilokat értékelésre. Ebben a randomizált nézetben a felhasználó három gombbal tud reagálni. Pozitív/semleges/negatív. A így adott három érték valamilyen számítás alapján képződjön le az értékelt személyre és az összesített pontszámát ez módosítsa. A cél, hogy minden hallgatónak a rendszerben van valamilyen jósági indexe, amelyet az így adott értékelések kis mértékben befolyásolnak; míg a nagy kifejtős értékelés kapcsán nagyobb mértékben befolyásol.

### Biztonsági intézkedések

- A rendszer figyeljen arra, hogy a kifejtős értékelésnél ne lehessen ilyen helykitöltő "lorem ipsum" jellegű szöveggel átverni a rendszert. Keressen a szövegben értelmes szavakat, mondatokat és csak ezeket engedje át.
- A rendszer figyeljen arra, hogy azon hallgatók akik gyanús viselkedési tendenciát mutatnak, legyenek egy időre bannolva a rendszerből. Gyanús viselkedés ha pl. megállás nélkül csak pozitív vagy csak negatív értékeléseket írnak, vagy esetleg túl gyorsan érkeznek tőle értékelések, ami így botszerű magatartásra utal.
- A rendszer figyeljen arra, hogy a hallgatói profilok valóban anoním módon tudjanak kezdetben kommunikálni a platformon.