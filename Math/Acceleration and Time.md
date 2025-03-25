### The Situation:
Several Objects are moving with the same acceleration in the same direction and have the same initial velocity. The distance between one and it’s nearest neighbour is supposed to be the same at all points time. The only part missing is the time between an object and its nearest neighbour reaching the same spot.

### Definitions:

##### Known:

$a$ is acceleration

$d$ is distance

##### Unknown:

$v$ is (final) velocity

$v_i$ is initial velocity

$v_a$ is average velocity

$t$ is time

### Known Formulae

$$
\begin{gathered}
d=v_a t \\\\
v=a t + v_i \\\\
v_a=\frac{v + v_i}{2} \\\\
a=\frac{v - v_0}{t} \\\\
\end{gathered}
$$

### Solving for $t$:

Inserting $v$ into $v_a$:

$$
\begin{aligned}
v_a &= \frac{v_i + a t + v_i}{2} \\\\
&= \frac{2 v_i + a t}{2}
\end{aligned}
$$

Inserting $v_a$ into $s$ :

$$
\begin{aligned}
d &= \frac{2 v_i + a t}{2} t \\\\
d &= v_it + \frac{a t}{2}t \\\\
d &= v_it + \frac{a t^2}{2} \\\\
0 &= v_it + \frac{a t^2}{2} - d \\\\
0 &= \frac{a t^2}{2} + v_i t - d \\\\
0 &= t^2 + \frac{2 v_i t}{a} - \frac{2 d}{a} \\\\
0 &= t^2 + \frac{2 v_i}{a} t - \frac{2 d}{a} \\\\
\end{aligned}
$$

Using the p-q-formula for t:

$$
\begin{gathered}
p = \frac{2 v_i}{a} \\\\
q = \frac{2 d}{a} \\\\
\end{gathered}
$$

$$
\begin{aligned}
t &= - \frac{p}{2} \pm \sqrt{(\frac{p}{2})^2 - q} \\\\
t &= - \frac{\frac{2 v_i}{a}}{2} \pm \sqrt{(\frac{\frac{2 v_i}{a}}{2})^2 - \frac{2 d}{a}} \\\\
t &= - \frac{v_i}{a} \pm \sqrt{(\frac{v_i}{a})^2 - \frac{2 d}{a}} \\\\
t &= - \frac{v_i}{a} \pm \sqrt{\frac{v_i^2}{a^2} - \frac{2 d}{a}} \\\\
t &= - \frac{v_i}{a} \pm \sqrt{\frac{v_i^2}{a^2} - \frac{2 a d}{a^2}} \\\\
t &= - \frac{v_i}{a} \pm \sqrt{\frac{v_i^2 - 2 a d}{a^2}} \\\\
t &= - \frac{v_i}{a} \pm \frac{\sqrt{v_i^2 - 2 a d}}{a} \\\\
t &= \frac{- v_i \pm \sqrt{v_i^2 - 2 a d}}{a}
\end{aligned}
$$

Since $d$ and $a$ are both positive and $v_i^2$ is too, the square root always has a solution. Since a square root is also always positive and the $t$ is required to be positive for our case as well the numerator of the fraction has to be positive. That can only be the case if the square root gets added onto $-v_i$ since it’s negative.

Therefore:

$$
t = \frac{- v_i + \sqrt{v_i^2 - 2 d a}}{a}
$$
