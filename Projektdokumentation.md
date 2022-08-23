# LA_1001

# Projekt-Dokumentation


Einzelarbeit, von Rogall

| Datum    | Version | Zusammenfassung                                                                            |
| -------- | ------- | ------------------------------------------------------------------------------------------ |
| 23.08.22 | 0.0.1   | Projektdokumentation. |
|          | 0.0.2   |   |
|          | 0.0.3   |   |
|          | 0.0.4   |   |

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
| 5    |  kann           |  Q   | Als Kunde möchte ich eine Applikation, welche beim erfolgreichen erraten der Zahl einen Audioeffekt abspielt, damit die Applikation interessanter wirkt.|
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
| 5.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die richtige Zahl wurde soeben erraten | Keine Eingabe | Ein Audioeffekt wird abgespielt |
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
| 5.A | 06.09.22 | Marek von Rogall | Ein Audioeffekt beim erraten der korrekten Zahl wird in das Spiel eingebaut | 30min |
| 6.A | 06.09.22 | Marek von Rogall | Die Eingabefelder im Spiel werden Orange gefärbt. | 30min |
| 7.A | 06.09.22 | Marek von Rogall | Der Hintergrund der Applikation wird grün eingefärbt. | 25min |
| 8.A | 06.09.22 | Marek von Rogall | Nur Integer Eingaben werden in Eingabefeldern akzeptiert. | 40min |

Total: 245min

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.