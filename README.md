# BruttoNettoRechner mit Arbeitgeber-Lohnkosten

Brutto-Netto-Rechner ist ein 'try-out', um C# WPF/MVVM Funktionalitäten zu testen und die Ermittlung des Nettolohns nach deutschem Steuerrecht in Anlehnung an die Programmablaufpläne des BMF (Bundesministerium für Finanzen) sowie der Arbeitgeber-Lohnkosten durchzuführen.

Die Anwendung ist stark vereinfacht und allenfalls eine Basis zur Weiterentwicklung. Es wird nur Lohsteuerklasse 1 richtig berechnet jedoch nicht gemäß Prüftabellen vollständig validiert.

Die Berechnung des Nettolohns erfolgt nur für "normal" gesetzlich pflichtversicherte Arbeitnehmer **ohne** Berücksichtigung des Alters (Altersfreibetrags), von Versorgungsbezügen, von Kinder-Freibeträgen, des Bundeslandes usw. Der Kirchensteuersatz kann gewählt werden und wird angewendet. Kinder-Freibeträge können per Liste, jedoch ohne Berechnung in der Anwendung, gewählt werden. Es steht eine kleine Auswahl an Krankenkassen zur Verfügung. Der jeweilige Zusatzbeitrag ist programmintern berechnet und kann nicht vom User gewählt werden.

Bei der Ermittlung der sozialen Lohnnebenkosten (Arbeitgeberbelastung) wurde U1 als gegeben unterstellt und kann nicht abgewählt werden. Der U1-Satz entspricht dem Standard-Satz der jeweiligen Krankenkasse und kann nicht geändert werden.

Die berechneten Werte können als XML-Datei exportiert werden.

**Es findet keine umfangreiche Daten-Eingabe Validierung statt, ebenso fehlt eine ausreichende Exceptionbehandlung!**
