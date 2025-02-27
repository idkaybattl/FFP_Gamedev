How to lernen how to machen Games fast (trust)!!!


# Einstieg

Wir wurden direkt am Anfang des Projektes vor eine Aufgabe gestellt: auf den Schulrechnern war keine Software installiert, mit welcher man ein Game programmieren könnte, also mussten wir erreichen, dass die nötigen Programme installiert werden. Was nach einiger Absprache mit dem Medienteam der Schule aber kein Problem war. In den Tagen, in denen wir noch nicht programmieren konnten, nutzten wir die Zeit, um uns schon mal einen Plan zu erstellen, wie wir fortfahren wollten. Als dann die Programme endlich installiert waren, kam das nächste Problem: Aufgrund eines Exams einer Referendarin, mussten wir für zwei Tage in einen anderen Raum, in dem uns unsere Programme wieder nicht zur Verfügung standen. Also arbeiteten wir schon mal an der Dokumentation unserer Arbeiten. Für den nächsten Tag, an dem wir die Programme nicht nutzen konnten, nahmen wir uns vor Laptops mitzunehmen, damit wir endlich programmieren konnten. So konnte es am 06.März endlich losgehen.


# Der Plan

Zunächst war der Plan, ein relativ einfaches 2D Retro-Game zu programmieren. Uns kamen sofort zwei Ideen in den Kopf: Ein Super-Mario-Clone oder ein Kultklassiker der Arcade-Gaming-Geschichte, nämlich Space Invaders. Da die Geschichte des Gamings mit dieser Art Spielen seinen Anfang fand, entschieden wir uns auch, damit unser Projekt zu beginnen (und weil das Ding fucking simpel ist). Als Zeitlimit nahmen wir uns den 20.03.2025, um genug Zeit für weitere Projekte zu haben.

Zu diesen anderen, sehr viel ambitionierten, Ideen von uns zählten Spiele, die einen großen Fokus auf 3D Grafiken legten und Spiele, die auf realistischen Physik-Simulationen aufbauen.

Eine Idee war ein Game, in dem man auf einem zufällig generierten Planeten startet und  sich mit den dort vorhandenen Ressourcen hochzuarbeiten, um andere Planeten zu erreichen und zu erobern. Wir hatten uns sehr viele Gedanken zu den technischen Details der Umsetzung gemacht und geplant, so viel wie möglich automatisch generieren zu lassen. Also im Prinzip genau der gleiche Grundsatz wie das 2016 veröffentlichte No Man’s Sky.


# Game Engine

Um mit dem Space-Invaders-Clone anzufangen, mussten wir uns für eine Game Engine entscheiden, da wir es uns nicht zur Aufgabe machen wollten alle grundlegenden Funktionen von Grund auf selber aufzubauen.

Zur Erklärung: Eine Game Engine ist ein Framework, also ein “Programmiergerüst”, das die Entwicklung eines Spiels vereinfachen soll und zur Steuerung des Spielverlaufs und der visuellen Darstellung dient. In den meisten Fällen sind in einer Engine bereits Plattformen integriert, um das Game in der Engine zu erstellen. Um unsere Vorhaben umzusetzen, kamen vier Engines für uns in Frage:


## Pygame

<https://github.com/pygame/pygame>

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXcmMe3j6MxnLF0FTstW3pB-ZiQKyez7jZ6fD31uAJRXei8bgc8xep9x_YcifDruwlBcdDQNRZnkxr8e3RclCSDtVeYbKLQVAuJbUA9vNb3IQKSD_xS9q7_57h3mOOm2wbSoQcDb?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Pygame ist Open-Source und eine sogenannte library für die populäre Programmiersprache Python. Es ist also keine Software, sondern eine große Ansammlung von Code, die man sehr einfach nutzen kann, um einem einige Arbeit abzunehmen. Es gibt einem einen einfachen Zugriff auf audiovisuelle Darstellung und auf die Verarbeitung von Spielerausgaben. Letztendlich ist es jedoch sehr viel weniger umfangreicher als unsere anderen Optionen und ermöglicht es einem außerdem nur 2D-Spiele für den Desktop zu erstellen.


## Unity

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXd0_hL4KHg7y9VzWaSV1qa4U8R9gr2uD8RjVpFWH2ezEQS0Qm1QnrZfDO9cFLmJ7zUBk5zGF9LQdQJSRvxJjPCQCzGGFvMbVd3j7P9lBcHazCaMoylt-d6rXr37bxrAjnqWhQY?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Unity ist für Hobbyisten schon seit Jahren der Standard für Spieleentwicklung. Es stellt einem eine relativ einfach zu spzfsch verstehende Entwicklungsumgebung bereit und hat Support für eigentlich jedes Feature, was man sich vorstellen kann. Man kann mit Unity sowohl 3D als auch 2D Spiele für alle Plattformen aufbauen und programmiert Scripts mit der Programmiersprache C# von Microsoft. Da es Unity schon so lange gibt, ist die Dokumentation zu dessen Nutzung sehr ausführlich.


## Unreal Engine

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXdKd8_5PN0m6W_fMLASrLEnsdzNdO4s7-TcEoj2eYoFy_fAUx4tUiqlWCD2jMFuwsbTJPH4FGAIc-qnIaEEs6icgt_hpH0RYWfFaf_GweHHhwa5kZ3iL4NtlS0YFMOwD1NjLRDi?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Unreal Engine ist die Engine, die der Konzern Epic-Games, welcher besonders **_FÜR FORTNITE_** bekannt ist, für seine Spiele nutzt. Der Fokus der Engine liegt hauptsächlich auf spezifischer 3D Grafik und erleichtert einem dessen Entwicklung substantiell. Viele große Spiele, auch abseits von Epic-Games,wurden mit Unreal entwickelt und punkten mit realistischer Darstellung, haben aber auch oft hohe Leistungsanforderungen. Unreal hat seine eigene Programmiersprache, nämlich UnrealScript, und mit Unreal lassen sich Spiele für den Desktop, das Handy, die Konsole und sogar für VR veröffentlichen.


## Godot

https\://github.com/godotengine/godot

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXeOqeaAGoc3-WnNsxPHdAsZ8ulIdeliwHkOyU6sY0HpmwjL_yUFNVCWhdwOISa-0BhzfPMGqcMKlcQGC_v_f85mBYVeFWuS4TlHOyjkfapVP0b_Z7ecMsNxTSevtYoOLULXy-0?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Als letztes dachten wir an die Open-Source Option Godot. Godot ist noch vergleichbar neu und hat nicht so große Firmen wie Unity und Unreal im Rücken, entwickelt sich jedoch extrem schnell voran und wird mittlerweile selbst mit den beiden marktführenden Engines, Unity und Godot verglichen. Godot hat sehr ähnliche Features und einen ähnlichen Aufbau wie Unity und Unreal, hat sich jedoch für eine lange Zeit nur auf 2D fokussiert und hat deswegen keine ganz so umfangreiche 3D Unterstützung. Mit Godot kann man sowohl Desktop, als auch Mobile und mit etwas Arbeit auch Console Games erstellen. Um für Godot zu programmieren kann man sowohl die eigene Sprache GDScript, die Python sehr ähnelt, als auch C# nutzen.


## Entscheidung

Wir entschieden uns aber relativ schnell für Unity, da es sowohl 2D als auch 3D Grafik unterstützt und wir so alle Projekte in derselben Engine umsetzen konnten. So sparten wir uns, mehrere Oberflächen von verschiedenen Engines zu lernen, was aufgrund der begrenzten Zeit besonders praktisch war.


# Lernplan

Um Unity zu lernen, werden in der Regel zwei Methoden empfohlen. Es gibt natürlich, wie für alles, Tutorials auf Plattformen wie Youtube. Man sagt sich jedoch, dass man diesen oft blind folgt und am Ende gar nichts gelernt hat. Die andere Option wäre die offizielle Dokumentation, die man sich in etwa wie ein sehr ausführliches schriftliches Tutorial vorstellen kann. Wir entschieden uns jedoch trotzdem, in unser erstes Projekt mit einem Youtube Tutorial zu starten, da die Unity Docs anfangs ein bisschen überfordernd wirken können. Danach werden wir natürlich trotzdem die offizielle Dokumentation für neue Konzepte und spezifische API Probleme nutzen.


# Unity

# Flappy Bird

# Game Development
