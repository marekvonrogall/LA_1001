# LA_1001

# Projekt-Dokumentation


Gruppe Marek von Rogall, von Rogall

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
| 3    |  muss           |  F   | Als Kunde möchte ich ein Programm welches mir die Anzahl Rateversuche am Schluss des Spiels anzeigt, damit man sich mit anderen Spielern vergleichen kann. |
| 4    |  muss           |  F   | Als Kunde möchte ich ein Programm, welches ich mit einem Tastendruck manipulieren und sofort gewinnen kann, damit ich besser bin als alle anderen. |
| 5    |  kann           |  Q   | Beim erfolgreichen erraten der Zahl wird ein Audioeffekt abgespielt. |
| 6    |  kann           |  Q   | Orange gefärbte Eingabefelder.  |
| 7    |  kann           |  Q   | Grün gefärbter Hintergrund, wenn die richtige Zahl erraten wurde.  |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe. | Die richtige Zahl wird nach n Versuchen erraten | Die Applikation ist beendet |
| 2.1  | Applikation gestartet, es wird in einem Benutzereingabefeld nach einer Zahlenspannweite gefragt. | String | Fehlermeldung "Bitte geben Sie nur Zahlen ein" |
| 3.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die richtige Zahl wurde erraten | Nach 5 Versuchen richtige Zahl erraten | Meldung: "Anzahl Rateversuche: 5" |
| 4.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, wartet auf Benutzereingabe. | Die Taste "H" wird während des Abschickens der Benutzereingabe gedrückt gehalten | Die Überprüfung der Benutzereingabe wird übersprungen. Die Anwendung zeigt an, dass die richtige Zahl erraten wurde. |
| 5.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die richtige Zahl wurde soeben erraten | Keine Eingabe | Ein Audioeffekt wird abgespielt |
| 6.1  | Applikation gestartet, zufällige Zahl wurde gerade generiert, das Feld für die Benutzereingabe erscheint | Keine Eingabe | Das Feld der Benutzereingabe ist orange |
| 7.1  | Applikation gestartet, zufällige Zahl ist bereits generiert, die richtige Zahl wurde soeben erraten | keine Eingabe | Der Hintergrund der Applikation färbt sich grün |


### 1.4 Diagramme

![Zahlenraten3](https://user-images.githubusercontent.com/110893394/186120279-582bb1af-e50a-4b0f-9387-425ac0a9aa21.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  30.08.22     | Marek von Rogall | Die basis Applikation ist fertig. Aus einer festgelegten Zahlenspannweite von 1-100 kann geraten werden, indem ein Eingabefeld erscheint, in welchem nur Zahlen im Integer Format angenommen werden. Die Anzahl der benötigten Versuche, bis die richtige Zahl erraten wurde, wird bereits angezeigt.          | 50min        |
| 1.A  |  30.08.22     | Marek von Rogall | Ein Eingabefeld mit einer selbst festlegbaren Zahlenspannweite funktioniert und nimmt nur Zahlen im Integer Format an.         | 30min         |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

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
