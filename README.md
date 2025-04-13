# Get good and how to lernen how to machen Games fast (trust)!!!

## Einstieg

Wir wurden direkt am Anfang des Projektes vor eine Aufgabe gestellt: auf den Schulrechnern war keine Software installiert, mit welcher man ein Game programmieren könnte, also mussten wir erreichen, dass die nötigen Programme installiert werden. Was nach einiger Absprache mit dem Medienteam der Schule aber kein Problem war. In den Tagen, in denen wir noch nicht programmieren konnten, nutzten wir die Zeit, um uns schon mal einen Plan zu erstellen, wie wir fortfahren wollten. Als dann die Programme endlich installiert waren, kam das nächste Problem: Aufgrund eines Exams einer Referendarin, mussten wir für zwei Tage in einen anderen Raum, in dem uns unsere Programme wieder nicht zur Verfügung standen. Also arbeiteten wir schon mal an der Dokumentation unserer Arbeiten. Für den nächsten Tag, an dem wir die Programme nicht nutzen konnten, nahmen wir uns vor Laptops mitzunehmen, damit wir endlich programmieren konnten. So konnte es am 06. März endlich losgehen.


## Der Plan

Zunächst war der Plan, ein relativ einfaches 2D Game zu programmieren, um die Oberfläche der Engine (dazu später mehr) zu lernen. Danach wollten wir mit dem ersten richtigen Projekt starten. Uns kamen sofort zwei Ideen in den Kopf: Ein Super-Mario-Clone oder ein Kultklassiker der Arcade-Gaming-Geschichte, nämlich Space Invaders. Da die Geschichte des Gamings mit dieser Art von Spielen seinen Anfang fand, entschieden wir uns, damit unser Projekt so richtig zu beginnen. (und weil das Ding fucking simpel ist).

Zu anderen, sehr viel ambitionierteren, Ideen von uns zählten Spiele, die einen großen Fokus auf 3D Grafiken legten und Spiele, die auf realistischen Physik-Simulationen aufbauen.

Eine Idee war ein Game, in dem man auf einem zufällig generierten Planeten startet und  sich mit den dort vorhandenen Ressourcen hochzuarbeiten, um andere Planeten zu erreichen und zu erobern. Wir hatten uns sehr viele Gedanken zu den technischen Details der Umsetzung gemacht und geplant, so viel wie möglich automatisch generieren zu lassen. Also im Prinzip genau der gleiche Grundsatz wie das 2016 veröffentlichte No Man’s Sky. Aufgrund der begrenzten Zeit beließen wir es aber bei 2D Grafiken.


## Game Engine

Um mit dem Space-Invaders-Clone anzufangen, mussten wir uns für eine Game Engine entscheiden, da wir es uns nicht zur Aufgabe machen wollten alle grundlegenden Funktionen von Grund auf selber aufzubauen.

Zur Erklärung: Eine Game Engine ist ein Framework, also ein “Programmiergerüst”, das die Entwicklung eines Spiels vereinfachen soll und zur Steuerung des Spielverlaufs und der visuellen Darstellung dient. In den meisten Fällen sind in einer Engine bereits Plattformen integriert, um das Game in der Engine zu erstellen. Um unsere Vorhaben umzusetzen, kamen vier Engines für uns in Frage:


### Pygame

<https://github.com/pygame/pygame>

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXdXSTGKX9eCy2sTFhmL0GarZLg3Cn9dOPh4bdT40h8TcKYQuzn_l1KFHca7zkz77Aj3nzNiXieTPZPwOGXZ2D_jGRTMb7um7OGpXlGppGkLFui0I6pRJEN6C-Tn95kQS4K0mkFi?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Pygame ist Open-Source und eine sogenannte library für die populäre Programmiersprache Python. Es ist also keine Software, sondern eine große Ansammlung von Code, die man sehr einfach nutzen kann, um einem einige Arbeit abzunehmen. Es gibt einem einen einfachen Zugriff auf audiovisuelle Darstellung und auf die Verarbeitung von Spielerausgaben. Letztendlich ist es jedoch sehr viel weniger umfangreicher als unsere anderen Optionen und ermöglicht es einem außerdem nur 2D-Spiele für den Desktop zu erstellen.


### Unity

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXewUhjzJ5R2vy0jGtFwnz4NMpib9Pi3EjKHlZ3PGGxbJjEfxKI-Rz1TsWJErxGwAB3aRtF6CwzXdUXBr3H6lxrkn71jOI3lS_OWEsza3kBBCHu6XsNeyqJx1OAjsDyvxsYN7Hk?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Unity ist für Hobbyisten schon seit Jahren der Standard für Spieleentwicklung. Es stellt einem eine relativ einfach zu spzfsch verstehende Entwicklungsumgebung bereit und hat Support für eigentlich jedes Feature, was man sich vorstellen kann. Man kann mit Unity sowohl 3D als auch 2D Spiele für alle Plattformen aufbauen und programmiert Scripts mit der Programmiersprache C# von Microsoft. Da es Unity schon so lange gibt, ist die Dokumentation zu dessen Nutzung sehr ausführlich.


### Unreal Engine

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXdHcxSkR1M5h9EWom9hWw2q7usGyEngUCIDhpp9n0iMDLfYLLDFDDEKFA31p4qG7-UEL_KIu6yWOwi89_o5QQh4PbhQq8PNQj1gI1teG_CZegYd-gefAOpqKj81qYjbnU0qjMIi?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Unreal Engine ist die Engine, die der Konzern Epic-Games, welcher besonders **_FÜR FORTNITE_** bekannt ist, für seine Spiele nutzt. Der Fokus der Engine liegt hauptsächlich auf spezifischer 3D Grafik und erleichtert einem dessen Entwicklung substantiell. Viele große Spiele, auch abseits von Epic-Games,wurden mit Unreal entwickelt und punkten mit realistischer Darstellung, haben aber auch oft hohe Leistungsanforderungen. Unreal hat seine eigene Programmiersprache, nämlich UnrealScript, und mit Unreal lassen sich Spiele für den Desktop, das Handy, die Konsole und sogar für VR veröffentlichen.


### Godot

<https://github.com/godotengine/godot>

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXcjcGGmsvvkIdMWVa5EO2PLMnW7Ag9-Kb1POZNp40kyz-hWf7fyZb5AHEbQQfESPwwAiHPJDrwn63CDheakMuRxN8-PGC6Hyt7uXvb6-5Ec5tuVYXSc0M7CO__UOoeBnP27E9I?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Als letztes dachten wir an die Open-Source Option Godot. Godot ist noch vergleichbar neu und hat nicht so große Firmen wie Unity und Unreal im Rücken, entwickelt sich jedoch extrem schnell voran und wird mittlerweile selbst mit den beiden marktführenden Engines, Unity und Godot verglichen. Godot hat sehr ähnliche Features und einen ähnlichen Aufbau wie Unity und Unreal, hat sich jedoch für eine lange Zeit nur auf 2D fokussiert und hat deswegen keine ganz so umfangreiche 3D Unterstützung. Mit Godot kann man sowohl Desktop, als auch Mobile und mit etwas Arbeit auch Console Games erstellen. Um für Godot zu programmieren kann man sowohl die eigene Sprache GDScript, die Python sehr ähnelt, als auch C# nutzen.


## Entscheidung

Wir entschieden uns aber relativ schnell für Unity, da es sowohl 2D als auch 3D Grafik unterstützt und wir so alle Projekte in derselben Engine umsetzen könnten. So sparten wir uns, mehrere Oberflächen von verschiedenen Engines zu lernen, was aufgrund der begrenzten Zeit aber unnütz war, da wir bei 2D Oberflächen blieben.


## Lernplan

Um Unity zu lernen, werden in der Regel zwei Methoden empfohlen. Es gibt natürlich, wie für alles, Tutorials auf Plattformen wie Youtube. Man sagt sich jedoch, dass man diesen oft blind folgt und am Ende gar nichts gelernt hat. Die andere Option wäre die offizielle Dokumentation, die man sich in etwa wie ein sehr ausführliches schriftliches Tutorial vorstellen kann. Wir entschieden uns jedoch trotzdem, in unser erstes Projekt mit einem Youtube Tutorial zu starten, da die Unity Docs anfangs ein bisschen überfordernd wirken können. Danach nutzten wir natürlich trotzdem die offizielle Dokumentation für neue Konzepte und spezifische API Probleme.


## Unity

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXc7fuo5uRnG7IssTtvMv45UEbaR-Q0sWdw5IBeWlngXJoywRUo-azXIus-a-k3YXlPlg7PPHmTPIGpgg2AGCHRwzGnk66517-9g4yFUwCyo6LjOdX0CSYd1pbj4Bifl1V77w0xi?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Der Unity Editor

In der Hierarchy werden die sogenannten GameObjects von Unity angezeigt. Alles in Unity ist grundsätzlich ein GameObject, ob Bild, Kamera, Lichtquelle, UI, oder auch Objekte, deren einzige Funktion das Verwalten anderer Objekte ist. Die Hierarchie ist als sogenannter Tree aufgebaut. Das heißt, dass einzelne Objekte anderen untergeordnet sein können, was man an Einrückung erkennen kann. Untergeordnete Objekte, sogenannte Children, übernehmen standardmäßig die Positionen von deren übergeordneten Objekten, den Parents. Wie im Editor sichtbar sind alle Objekte Children einer Szene, welche standardmäßig SampleScene genannt wird. In dem laufenden Spiel kann immer nur eine Szene auf einmal aktiv sein. Die Children der Szene sind dann die, die angezeigt und berechnet werden, währenddessen alles aus anderen Szenen ignoriert wird. Das kann beispielsweise hilfreich für verschiedene Level sein.

In dem Scene View Fenster kriegt man eine Vorschau der Szene. Dort ist jedes Child der Szene zu finden. In diesem Fall ist die Szene im 3D Modus, man kann das Fenster aber auch über den oben zu findenden Knopf in den 2D Modus verschieben. In diesem Fall bleibt die 3. Dimension zwar bestehen, jedoch sieht man die Szene nur noch aus einer 2-dimensionalen Perspektive. In dem Scene View Fenster lassen sich alle GameObjects visuell bearbeiten. Man kann sie mit Hilfe der oben-links zu findenden Werkzeuge verschieben, transformieren und vieles mehr.


## Flappy Bird

## Game Development

Jedes Computerspiel ist erstmal einfach nur ein normales Programm, welches vom PC ausgeführt wird. Im Zentrum von dem Programm liegt die Game-Loop, eine Game-Loop ist grob gesagt eine Menge an Code, die häufig in jedem Frame ausgeführt wird. Frames sind die Bilder, die durch die Pixel eines Bildschirms dargestellt werden. Computer geben Videos in Form von einer bestimmten Anzahl an Frames in einer gewissen Zeit aus. Das heißt, dass Bildschirme verschiedene Bilder ganz schnell hintereinander abspielen, um ein Video zu erzeugen. Diese Anzahl an benötigten Frames wird in Abständen von einer Sekunde gerechnet, also Frames per Second (FPS). Je höher die FPS, desto flüssiger ist das Video oder in unserem Fall das Spiel. So wurden Spiele früher, so um die 2000er, in bis zu 30 fps programmiert, heute sind 60-144fps Standard.

Die Game-Loop berechnet, was der Bildschirm anzeigen soll, aber auch Dinge wie die Logik hinter dem Spiel. Die Logik beschreibt z.B. Positionen von Objekten oder physikalische Phänomene, wie das Licht. Die Game-Loop wird zwar häufig in jedem Frame, also 60-144 mal in der Sekunde ausgeführt, es gibt aber auch Beispiele, in denen die Game-Loop häufiger angewendet wird. Game-Loop und FPS sind also nicht zwingend aneinander geknüpft und können auch separat laufen. In unserem Fall sind sie aber zusammenhängend.


### Graphics

#### Shader

Zum Verstehen von den Prinzipien hinter der Grafik von Videospielen, und was diese limitiert, sollte man erst einmal den Grundaufbau eines Computers kennen. Alles hier Erklärte lässt sich im Übrigen auch auf Handys, Konsolen und eigentlich fast alle anderen Geräte, die einen Bildschirm betreiben. beziehen.

Das Herzstück von jedem Computer ist die CPU (central processing unit). Wie der Name schon sagt, ist dieser Chip zur Verarbeitung von Daten da. Die CPU kann alle Anweisungen ausführen, Rechnungen durchführen und andere Bauteile des Computers kontaktieren. Sie organisiert alles, was im Computer passiert. Die meisten modernen CPUs lassen sich jedoch in mehrere Cores aufteilen. Jeder Core ist eine eigenständige, kleinere CPU, die nicht mit den anderen interagieren kann. Die Idee dahinter ist, dass sich so mehrere Aufträge, die die CPU bekommt, parallel bearbeiten lassen. Auf Seite der Software kommen noch sogenannte Threads hinzu. Diese sind sozusagen das softwareseitige Äquivalent von Cores. Auf sie werden die Aufgaben so verteilt, dass selbst einzelne Cores mehrere Anweisungen parallel ausführen können. Jeder Thread bekommt also genauso, wie ein Core Anweisungen zugeordnet und führt diese auf dem Core mit den ihm zur Verfügung stehenden Ressourcen aus, ohne zu wissen, was die anderen Threads tun, oder für Zwischenergebnisse haben. Die meisten CPUs haben in der Regel maximal 8 Kerne, mit einigen Ausnahmen, die sich aber auch in deren Preis widerspiegeln. An Threads gibt es bei normalen CPUs normalerweise auch nur bis zu 2 pro Core.

Das für diesen Abschnitt noch interessantere Bauteil, jedoch, ist die GPU (graphics processing unit), dessen Hauptaufgabe die Berechnung der Grafik ist. Das Prinzip der GPU ist exakt das gleiche, wie das der CPU. Der einzige große Unterschied liegt nämlich in der Cores. Anders als die CPU, hat eine GPU deutlich mehr, kleinere und spezialisierte Cores. Diese können nicht so komplizierte Berechnungen, wie die einer CPU durchführen, eignen sich aber besonders für Grafik gerade wegen ihrer Masse gut. Bildschirme zeigen ihr Bild bekanntlich mit Pixeln an. Ganz viele kleine Punkte in einem Gitter angeordnet. Und von diesen gibt es verdammt viele. Ein normaler Full HD Bildschirm hat 1080 \* 1920, also insgesamt knapp über 2 Mio. Pixel. Die GPU ist demnach perfekt für Grafik, da sie die Farbe der Pixel nicht nacheinander berechnen muss, sondern ihre vielen Cores und Threads zur parallelen Berechnung von ganz vielen Pixeln auf einmal nutzen kann. Oft sind GPUs in den CPUs direkt eingebaut. Von Gaming kennt man die GPU aber in der Regel als sowohl teuerstes als auch größtes Bauteil des PCs.

Die Programme, die auf der GPU laufen, heißen in unserem Kontext Shader. Die GPU muss aber nicht zwingend zur Berechnung von Grafik genutzt werden. Die anderen Programme, die auf der GPU laufen, nennen sich Compute Shader. Es gibt verschiedene Wege die GPU zu programmieren. Sogenannte 3D Grafik APIs, wie OpenGL, Vulkan und DirectX sind Libraries, die es einem ermöglichen, Computergrafik zu erstellen. Dazu zählt sowohl das Verwalten der Szene mit 2D- und/oder 3D-Objekten, aber auch das Ausführen von Shadern mit eigenen Programmiersprachen, wie GLSL und HLSL. Ohne diese Grafik APIs ist es für Einzelpersonen praktisch unmöglich, mit Grafik zu arbeiten. Es gibt zwar einige andere Wege, wie in unserem Fall zum Beispiel Unity, aber selbst solche Programme benutzen im Hintergrund, genauso wie selbst die modernen Betriebssysteme, in der Regel mindestens eine dieser 3 Grafik APIs. Der Nachteil an diesen APIs ist, dass beispielsweise Vulkan, was noch relativ neu und entsprechend schnell ist, von einigen alten Geräten nicht unterstützt wird. Deswegen ist es so praktisch, Programme wie Unity für so etwas zu nutzen, da diese einem solche Probleme vollkommen abnehmen.


#### Assets

Assets sind GameObjects in Unity, die einfach gesagt vom Spieler wahrnehmbar sind. Dazu zählen also Bild, Audio und vieles mehr.


#### 2D

##### Sprites

In Unity sind Sprites zweidimensionale Assets mit einem SpriteRenderer Component, welcher ein Bild, bzw. eine Textur an der Position der Sprite anzeigt. Sprites sind einfach gesagt also Bilder. In der Regel ist also alles sichtbare eines 2D Spiels, abgesehen von der UI eine Sprite.

Spiele früher hatten noch sehr niedrige Auflösung und die Sprites dieser Spiele waren entsprechend pixelig. Ob aus Nostalgie oder aus anderen Gründen ist dieser Stil selbst bis heute geblieben, besonders bei Indie Spielen, also bei Spielen mit niedrigem Budget.


##### Layer

Sprites liegen auf verschiedenen Ebenen. Die meisten 2D-Spiele sind nämlich zwar 2-dimensional, müssen die 3. Dimension aber ebenfalls beachten.


#### 3D

##### 3D Modelle

3D Modelle sind die Sprites der 3D Spiele. Sie bestehen aus sogenannten Polygons, also Dreiecken. Dreiecke sind sehr praktisch, da alle drei Eckpunkte, anders als bei allen anderen Formen, immer auf einer Ebene liegen. Außerdem sind GPUs darauf ausgelegt, möglichst schnell Dreiecke zu rendern, weswegen es Verschwendung wäre andere Formen zu nutzen. In 3D-Modellierungssoftware lassen sich trotzdem oft Rechtecke finden, das ist jedoch nur zur Darstellung, da es oftmals für Menschen einfacher zu verstehen ist. Die Modelle werden also selbst in solchen Fällen mit Dreiecken als Polygons gespeichert. Insgesamt hat ein Polygon somit pro Ecke 3 Werte, à 8 Bit, also braucht alleine ein Polygon 81 Bit, bzw. 9 Byte. In einzelnen Szenen lassen sich aber oft tausende oder sogar an die Millionen Polygons finden. Es wird wahrscheinlich klar, wie viel Speicher und Rechenleistung 3D Grafik benötigt. Deswegen sahen die ersten erfolgreichen 3D Spiele auch so aus:

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXfZphSB-c5xK2HUEb9IWLGTsxoZa_4R5Obhr1KJb4HeksowmwlbubYIK055HnQmTHU8WBCvRHphRFmL4u3QAlf9j-mpYvUmWqa5LJb-GfTtU5ywfooxZq4C5dJiebeNHYf_hWS0?key=6S1NaVUTGK1O6Dqnuf_APZFu)

Logischerweise ist die beste Methode zur Leistungslast-Senkung das Reduzieren der Polygons. Und das passiert auch oft, aber gottseidank ist unsere Technologie seit dem N64 um einiges fortgeschritten. GPUs sind unglaublich schnell geworden und Arbeitsspeicher unglaublich groß. Man kann sich oft unter 16GB gar nichts genaues vorstellen. Giga steht nicht für eine Millionen, sondern für eine Milliarde. Man kann im normalen PC Arbeitsspeicher ganze 128 Milliarden kleine Schalter, die an oder aus sind, finden. Vor einigen Jahren waren solche Zahlen noch unvorstellbar.


##### Lighting

Um das Lighting zu erklären, müssen wir erstmal die verschiedenen Arten von Lichtquellen beschreiben: Als erstes ist da das Pointlight. Das Pointlight beschreibt einen Punkt, der in alle Richtungen Licht abgibt. Das ist perfekt für Dinge wie  Fackeln. Dann gibt es noch das Directionallight, das sind Lichtstrahlen, die parallel in eine Richtung verlaufen. Man benutzt das Directionallight für Dinge wie Sonne oder Mond, also Sachen, die sehr weit weg sind. Als letztes ist da das Arealight, bei dem wird Licht von einer Fläche verstreut, das ist also besonders für Scheinwerfer geeignet. Da es nahe ist und das Licht nicht nur von einem Punkt kommt.


###### Raytracing

Beim Raytracing wird ähnlich wie in der Natur simuliert. In der Natur fällt das Licht einfach gesagt auf ein Objekt und wird von diesem in unser Auge reflektiert, durch das Licht, welches in unser Auge fällt, können wir sehen. In einem Videospiel macht es nur keinen Sinn die Lichtwellen von der lichtquelle aus zu simulieren, da es zu viel Rechenleistung verbrauchen würde Objekte zu simulieren die, man sowieso nicht sehen könnte da die Lichtwellen nicht ins “Auge” fallen würden. Deswegen simuliert man die Lichtwellen von der Kamera aus. So simuliert man nur die Belichtung der Objekte, die man auch sehen würde. Die Lichtwellen haben Regeln, nach den sie sich verhalten, so prallen sie je nach Beschaffenheit des Objekts nach physikalischen Gesetzen ab oder werden durchgelassen z. B. bei einer Glasscheibe. Das geht dann solange, bis der Strahl eine Lichtquelle erreicht hat, die maximale Anzahl an Treffern erreicht wird oder die Strahlen zu große Distanz zurückgelegt haben. Wenn das Licht dann die Lichtquelle erreicht hat, wird der Wert der Farbe mit der zurückgelegten Distanz und den berührten Objekten berechnet. Wenn ein Strahl keine Lichtquelle findet, wird der dazugehörige Pixel schwarz. Deswegen werden mehrere Lichtstrahlen mit verschiedenen Zufallswerten pro Pixel abgeschickt und die Durchschnittsfarbe wird berechnet. Da das aber immer noch zu problemen führen kann wird mit blurrs gearbeitet, aufgrund dessen, dass das aber sehr kompliziert ist lassen wir das erstmal unbehandelt. Das Raytracing ist unfassbar rechenintensiv. Zur Erklärung: ein normaler Bildschirm mit dem Verhältnis 16:9 hat ca. 2 Mio Pixel. und für jeden dieser 2 Mio Pixel werden mehrere Rays, also Lichtstrahlen simuliert. Um diese Rechenleistung bewerkstelligen zu können, gibt es Grafikkarten auch (gpu) abgekürzt. Sie haben das gleiche Prinzip wie eine CPU, nur dass sie ganz viele kleinere Berechnungen parallel machen können. Auch hier ist die Technologie in den letzten Jahren durch die Decke gegangen. Da Preis und Leistung bei Gpus nicht zwingend Proportional sind und gpus dementsprechend teuer sind, gibt es andere Tricks.   

![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXdoN77QJqVNR6-4Q-96XnqYj_DiUi-TGnUwRUW1M2pEeJwKZcitN1b4ArpfEDc4pvQyaWfk7uyjHxDmixikZkX6m7UmjGVRv3r9NOHx4sPoDcLRYJHjBYGDHUbFCGoDeH4OnoWN?key=6S1NaVUTGK1O6Dqnuf_APZFu)


###### Phong- und Blinn-Phong-Modell

- Objektorientiert

- also anders als globales raytracing werden alle objekte separat behandelt und schatten oder andere interaktionen zwischen objekten müssen separat hinzugefügt werden

- nicht so realistisch wie raytracing

- aber halt sehr viel weniger rechenintensive

- erstmal wird jedem pixel das nächste polygon zugeordnet also das polygon das auf dem pixel zu sehen ist

- normalisierte vektoren sind vektoren die so gekürzt / verlängert sind, dass sie länge 1 haben

- also normalisierter vektor  = vektor / länge des vektors

- dann hat man nen normalisierten vektor für die lichtrichtung

- nen normalisierten normal-vektor des polygons, der eif sozusagen die blickrichtung des polygons zeigt

- und normalisierten vektor der blickrichtung

- bei dem phong modell nimmt man grundsätzlich das skalarprodukt von normal und lichtrichtung plus das skalarprodukt von berechneter reflektionsrichtung und blickrichtung

- dazu kommen noch 3 konstanten die aus den objekteigenschaften genommen werden

- dann bekommt man![](https://lh7-rt.googleusercontent.com/docsz/AD_4nXe5IMM_TwBRC7MrL6g3ancW4cFdLGM_xAVoL36cEtR0kMoxl2342N2XrSYVQ3rWR3megZCypsqL5iltOTLgqdFkLeIlplyLO05sjmgjAJhvTBx8LInoYS2smSni8H6aFgnaZel0?key=6S1NaVUTGK1O6Dqnuf_APZFu)

- <https://en.wikipedia.org/wiki/Phong_reflection_model>

- bliss phong modell ist eig eif das gleiche nur dass leute so ne optimierung gefunden haben um diese vektor multiplikation für computer zu erleichtern

- beim phong modell muss man den großteil der rechnung so oft wie die anzahl der lichter in der szene ausführen und das aufaddieren

- man kann aber auch den mittelvektor zwischen lichtquellenvektor und blickrichtung nehmen und ihn mit normal multiplizieren

- dann muss man nicht jedes mal den reflektionsvektor berechnen was glaubich rechenintensiver als das berechnen vom mittel- oder eig halbvektor ist

- hoffe ich hab das verstanden die wikipediaartikel waren bissl kurz und kompliziert gefasst: <https://en.wikipedia.org/wiki/Blinn%E2%80%93Phong_reflection_model>

- aber um das ganze ding kurz zu fassen:

- man guckt sich die verhältnisse der oben genannten drei winkel an

- dann guckt man wie nah der blickwinkel am reflektionswinkel ist und passt das ergebnis mit den objekteigenschaften an und hat dann die lichtstärke die vom objekt ausgeht

- dann findet man noch die farbe über objektfarbe oder textur heraus und färbt dann den pixel entsprechend ein


##### 3D Texturen

- unwrapping


##### Normal Maps

- zeigt die normal werte eines 3d modells in ner unwrappten textur

- man kann die bearbeiten und damit coole effekte erzeugen wie z.b. bei nem low poly model ne textur einbauen die mit licht interagiert

linear und bilinear interpolation ((perlin) noise)

bezier curves & surfaces


#### Anti Aliasing

#### Particle Systems gehört aber eig auch zu physics idk wo ich das hinpacken soll

- Nebel:

- der wird aber auch oft gemacht indem man eif die entfernung des polygons nimmt und desto weiter entfernt dieses ist es entsprechend einfärbt

- gibt auch noch einige andere komplexe methoden für nebel

- explosionen:

- joa is halt das gleich wie nebel mit cooleren farben

- wasser simulation:

- funktioniert basically wie nh bällebad


### Physics

#### Position and Movement

Jedes Objekt, das von der Physik beeinflusst wird, hat Werte für Position, Geschwindigkeit, und falls vorhanden Beschleunigung. Die Position ist eine Koordinate, mit 2-3 Werten je nach Dimension. Geschwindigkeit und Beschleunigung sind Vektoren mit gleicher Anzahl an Werten. So kann man mit 2-3 Werten sowohl die Richtung als auch die Kraft der Geschwindigkeit und Beschleunigung speichern.

In jedem Durchgang der Gameloop wird die neue Geschwindigkeit aus der Beschleunigung berechnet und aus der Geschwindigkeit die neue Position. Das funktioniert indem man auf den alten Wert der Position oder der Geschwindigkeit, die Geschwindigkeit oder die Beschleunigung mal Delta-Time addiert. 

Geschwindigkeit = alte Geschwindigkeit + Beschleunigung \* Zeit

Position = alte Position + Geschwindigkeit\* Zeit

Die Delta-Time ist nämlich die Zeit, die seit dem letzten Gameloop-Durchgang vergangen ist. So garantiert man, dass sich alles gleich verhält, unabhängig von Framedrops, also unabhängig davon, ob die Gameloop mal länger braucht. Das ist besonders wichtig, da vor allem bei Multiplayer Spielen alles synchronisiert bleibt, auch wenn es bei einem laggt.

In Unity hat jedes einzelne Gameobject den “transform component”. Dieser gibt dem Objekt Werte für Position in Szene, seine Größe und seine Rotation. Wenn man möchte, dass sich die Objekte bewegen, braucht man ein Physics component wie “rigidbody (2D oder 3D)”. Der erlaubt es einem, dem Objekt Geschwindigkeit und Beschleunigung zu geben.


#### Collisions

- component den man an ein objekt anhängen kann

- prüft ob ein anderer collider innerhalb von dem eigenen collider ist

- kann unterschiedliche formen haben

- in der regel sehr einfache formen wie boxen oder kugeln, weil desto einfacher die form desto einfacher ist es zu berechnen ob irgendein anderer collider innerhalb davon ist

- wenn eine collision detected wird werden die objekte standardmäßig von unity erstmal wenn möglich eif so platziert, dass sie keine collision mehr haben

- man kann aber eigenes verhalten einprogrammieren

- bei sich schnell bewegenden dingen stellt sich ein neues problem auf

- manchmal bewegen sich collider so schnell dass sie in keinem durchlauf der gameloop in einer collision sind, sich aber trotzdem durch einen anderen collider durchbewegt haben zwischen den berechnungen der gameloop

- für projektile wie zum beispiel schüsse, also dessen kugeln werden oft rays benutzt

- also strahlen die prüfen ob sie irgendwo durch einen collider gehen

- da gibts das problem dass die strahlen nur gerade sein können

- wenn man kurven haben will muss man also mehrere kleinere strahlen machen

- bei objekten die nicht nur in einem frame diese collision testen wollen, sich also für längere zeit schnell bewegen kann man auch jeden frame einen ray von der alten position zur jetzigen machen

- und wenn selbst zwischen dem frame eine gekurvte bewegung war kann man das auch in mehrere kleinere rays aufteilen

- ab dann werden aber in jedem fall die benötigten mathe kentnisse sehr tiefgehend 


### Mechanics

## Fazit

***


## Aufbau

- **Themenwahl**

* **Pläne**

  - _was kleines 2d zum Anfang_

  - _Retro Games_

  - _Space Invaders_

  - _sidescroller platformer mario-like_

  - _3d physics simulationen sind super_

  - _no mans sky_

  - _irgendwas anderes idk_

- **Game Engine**

  - _was das_

  - _warum spzfsch unity_

  - _was hat unity so_

* **Lernplan**

- **Start**

  - _block fällt auf Platte_

  - _Rigidbody und so_

* **Wie funktioniert Game Development**

  - _eig keine festen Regeln_

  - _sehr unterschiedlich zwischen Projekten_

- **Arten von Spielen**

  - _2D_

  - _2.5D spzfsch_

  - _3D_

  - _turn based_

  - _frei kontrollierbarer character / live:_

  - _…_

* **Game Development**

  - _wir behandeln nur live spiele weil sonst wär nich wirklich video game und sonst engine useless_

* **_Graphics_**

* _3D Models_

* _Sprites_

* _3D / 2D Animation_

* _Shaders (compute,vertex,fragment…)_

  - _Gras_

* **_Physics_**

  - acceleration

  - velocity

  - position

  - vectors

* **_Mechanics_**

  - _komplett Spiel-Spezifischer-Spezi-Fisch_ 

* **Fazit** 

\


**j.pohlmann\@uni-muenster.de**

