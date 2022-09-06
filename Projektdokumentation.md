# LA_1001

# Projekt-Dokumentation


Einzelarbeit, von Rogall

| Datum    | Version | Zusammenfassung                                                                            |
| -------- | ------- | ------------------------------------------------------------------------------------------ |
| 23.08.22 | 0.0.1   | Projektdokumentation. |
| 30.08.22 | 0.0.2   | Programmieren.  |
| 06.09.22 | 0.0.3   | Projektdokumentation. |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Spiel in welchem der Benutzer die richtige, zufällig generierte Zahl erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  muss           |  F   | Als Kunde möchte ich ein Spiel haben, in welchem man eine zufällig generierte Zahl erraten muss, um zu gewinnen, damit ich mir mit dem Spiel die Zeit vertreiben kann.
| 2    |  muss           |  F   | Als Kunde möchte ich in einem Eingabefeld die Spannweite der zufälligen Zahlen selbst auswählen können, damit der Schwierigkeitsgrad des Spiels angepasst werden kann. |
| 3    |  muss           |  F   | Als Kunde möchte ich eine Applikation, welches mir die Anzahl Rateversuche am Schluss des Spiels anzeigt, damit man sich mit anderen Spielern vergleichen kann. |
| 4    |  muss           |  F   | Als Kunde möchte ich eine Applikation, welches ich mit einem Tastendruck manipulieren und sofort gewinnen kann, damit ich öfters gewinne als meine Mitspieler. |
| 5    |  muss           |  Q   | Als Kunde möchte ich eine Applikation, welche während des Ratens eine Auflistung der zu grossen und zu kleinen Eingaben anzeigt, damit man immer den Überblick über bereits getätigte Eingaben behält.|
| 6    |  kann           |  Q   | Als Kunde möchte ich eine Applikation, welche orange gefärbte Eingabefelder besitzt, damit die Applikation ansprechender wirkt. |
| 7    |  kann           |  Q   | Als Kunde möchte ich eine Applikation, welche den Hintergrund grün einfärbt, wenn die richtige Zahl erraten wurde, damit die Applikation ansprechender wirkt. |
| 8    |  muss           |  F   | Als Kunde möchte ich eine Applikation, welche bei einer Eingabe falschen Formats eine Fehlermeldung ausgibt, damit keine Fehler im Programm entstehen. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe. | 20; 90; 60; 52 | Die Applikation ist beendet |
| 2.1  | Applikation gestartet, es wird in einem Benutzereingabefeld nach einer Zahlenspannweite gefragt. | 20; 341 | Die Applikation wählt eine zufällige Zahl wischen 20 und 341. |
| 3.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die richtige Zahl wurde erraten | 93; 21 | Meldung: "Anzahl Rateversuche: 2" |
| 4.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe. | Die Taste "H" wird während des Abschickens der Benutzereingabe gedrückt gehalten | Die Überprüfung der Benutzereingabe wird übersprungen. Die Anwendung zeigt an, dass die richtige Zahl erraten wurde. |
| 5.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die erste Eingabe wurde getätigt. | 45 | Die 45 wird entweder bei den zu grossen oder bei den zu kleinen Eingaben aufgelistet. |
| 6.1  | Applikation gestartet, zufällige Zahl wurde gerade generiert, das Feld für die Benutzereingabe erscheint | Keine Eingabe | Das Feld der Benutzereingabe ist orange |
| 7.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die richtige Zahl wurde soeben erraten | keine Eingabe | Der Hintergrund der Applikation färbt sich grün |
| 8.1  | Applikation gestartet, wartet auf Eingabe des Benutzers. | String | Fehlermeldung: "Es werden nur ganze Zahlen angenommen" |


### 1.4 Diagramme

![Zahlenraten3](https://user-images.githubusercontent.com/110893394/186120279-582bb1af-e50a-4b0f-9387-425ac0a9aa21.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  30.08.22     | Marek von Rogall | Die basis Applikation ist fertig. Aus einer festgelegten Zahlenspannweite von 1-100 kann geraten werden, indem ein Eingabefeld erscheint. | 50min        |
| 2.A  |  30.08.22     | Marek von Rogall | Ein Eingabefeld mit einer selbst festlegbaren Zahlenspannweite funktioniert und nimmt nur Zahlen im Integer Format an.         | 30min         |
| 3.A  |  30.08.22  | Marek von Rogall    | Eine Ausgabe der benötigten Versuche bis zum erraten der richtigen Zahl wird in das Spiel eingebaut. | 20min |
| 4.A  |  30.08.22  | Marek von Rogall    | Ein Trick im Spiel für das überspringen der Überprüfung der Richtigkeit der eingegebenen Zahl wird in das Spiel eingebaut. | 20min |
| 5.A | 06.09.22 | Marek von Rogall | Eine Auflistung aller zu grossen und zu kleinen Eingaben wird während des Spielens und nach dem Erraten der richtigen Zahl angezeigt. | 30min |
| 6.A | 06.09.22 | Marek von Rogall | Die Eingabefelder im Spiel werden Orange gefärbt. | 30min |
| 7.A | 06.09.22 | Marek von Rogall | Der Hintergrund der Applikation wird grün eingefärbt. | 25min |
| 8.A | 06.09.22 | Marek von Rogall | Nur Integer Eingaben werden in Eingabefeldern akzeptiert. | 40min |

Total: 245min

## 3 Entscheiden

Ich nehme an, dass der Kunde möchte einen hellgrünen Hintergrund, keinen dunkelgrünen, wenn die richtige Zahl erraten wurde.

Ich nehme an, dass der Kunde beim auswählen der Zahlenspanne zuerst die kleine und dann die grosse Zahl oder zuerst die grosse und dann die kleine Zahl eingeben möchte, ohne dass das Programm einen Fehler ausgibt.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30.08.22 |  Marek  |     50min     |      30min       |
| 2.A  | 30.08.22 |  Marek  |     30min     |      15min     |
| 3.A  | 30.08.22 |  Marek  |     20min     |      15min     |
| 4.A  | 30.08.22 |  Marek  |     20min     |      40min      |
| 5.A  | 30.08.22 |  Marek  |     30min     |      35min       |
| 6.A  | 30.08.22 |  Marek  |     15min     |      10min       |
| 7.A  | 30.08.22 |  Marek  |     15min     |      10min |
| 8.A  | 30.08.22 |  Marek  |     40min     |      40min          |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  30.08.22  |  Die fertige  Basis-Applikation funktioniert reibunglos.  |  Marek |
| 2.1  |  30.08.22  |  Das Eingeben der Zahlenspanne funtioniert. Es ist nur möglich die kleinere Zahl zuerst einzugeben. Bei Eingaben des falschen Dateityps gibt das Spiel einen Fehler aus.        |  Marek     |
| 2.2  |  30.08.22  |  Das Eingeben der Zahlenspanne funktioniert. Es ist nun möglich die kleinere Zahl oder die grössere Zahl zuerst einzugeben. Bei Eingaben des falschen Dateityps gibt das Spiel einen Fehler aus.   |  Marek |
| 2.3  |  30.08.22  |  Das Eingeben der Zahlenspanne funktioniert. Es ist nun möglich die kleinere Zahl oder die grössere Zahl zuerst einzugeben. Bei Eingaben des falschen Dateityps fragt das Spiel nach einer neuen Eingabe.   |  Marek |
| 4.1  |  30.08.22  |  Die Eingabe eines "h" im Anschluss einer Zahl führt zum sofortigen Gewinnen des Spiels.    |  Marek |
| 5.1  |  30.08.22  |  Eine Auflistung der bisherigen zu grossen und zu kleinen Rateversuche wird während des Spiels angezeigt.   |  Marek |
| 5.2  |  30.08.22  |  Eine Auflistung der Rateversuche wird nach der Eingabe der gesuchten Zahl ebenfalls im "Gewonnen-Bildschirm" angezeigt.   |  Marek |
| 6.1  |  30.08.22  |  Die Eingabefelder des Benutzers sind orange.   |  Marek |
| 7.1  |  30.08.22  |  Der Hintergrund färbt scih grün, sobald das Spiel gewonnen wurde.   |  Marek |
| 8.1  |  06.09.22  |  Die Eingaben der Zahlenspannweite nehmen nur Eingaben im Integer-Format an.   |  Marek |
| 8.2  |  06.09.22  |  Die Eingaben zum Erraten der gesuchten Zahl nehmen nur Eingaben im Integer-Format an, ausser die Eingabe enthält ein "h" an letzter Stelle.  | Marek |


✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

[Lern-Bericht](https://github.com/marekvonrogall/LA_1001/edit/main/Projektdokumentation.md)
