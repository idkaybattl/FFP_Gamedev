### The Situation
Given a ray and a sphere in 3-dimensional space we want to determine wether the ray intersects the sphere at any point.

### Definitions

##### Known:

$O$ is the origin of the ray

$\vec D$ is the normalised Vector of the direction the ray is facing

$P$ is the position of the sphere

$r$ is the radius of the sphere

##### Unknown:

$H$ is a position along the ray

$d$ is distance

### Known Formulae:

Sphere (assuming $P = (0, 0, 0)$ ):

$$
\begin{gathered}
x^2 + y^2 + z^2 = r^2 \\\\\\
H = O + \vec D d
\end{gathered}
$$

Since $P$ has to be at $(0, 0, 0)$ for the Spehere‘s equation to work:
Going Foward:

$P'$ is the adjusted position of the sphere
$O'$ is the adjusted origin of the ray

$$
P = (0,0,0)
$$

and therefore:

$$
O' = O - P
$$


### Calculaion

Find a formula for $H$ where it lies on the surface of the Sphere.
So:

$$
(x,y,z) = H
$$

according to Pythagoras the length $l$ of a vector $\vec V$ squared:

$$
l^2 = \Vert \vec V \Vert^2 = \Vert (x,y,z) \Vert^2 = x^2 + y^2 + z^2
$$

Therefore:

$$
\begin{aligned}
\Vert H \Vert^2 &= r^2 \\\\
\Vert (O' + \vec D d) \Vert^2 &= r^2
\end{aligned}
$$

Since the Dot Product of a Vector $\vec V$ to itself is it’s squared length:

$$
\vec V \cdot \vec V = \Vert \vec V \Vert^2
$$

This is true:

$$
\begin{aligned}
(O' + \vec D d) \cdot (O' + \vec D d) &= r^2 \\\\
O' \cdot O' + O' \cdot \vec D d + O' \cdot \vec D d + \vec D d \cdot \vec D d &= r^2 \\\\
O' \cdot O' + 2 O' \cdot \vec D d + \vec D \cdot \vec D d^2 &= r^2\\\\
\vec D \cdot \vec D d^2 + 2 O' \cdot \vec D d + O' \cdot O' - r^2 &= 0
\end{aligned}
$$

Using the quadratic formula for d:

$$
\begin{aligned}
a &= \vec D \cdot \vec D \\\\
b &= 2 O' \cdot \vec D d \\\\
c &= O' \cdot O' - r^2 \\\\\\
\end{aligned}
$$

$$
\begin{gathered}
d = \frac{-b \pm \sqrt{b^2 - 4 a c}}{2 a} \\\\
d = \frac{- 2 O' \cdot \vec D d \pm \sqrt{(2 O' \cdot \vec D d)^2 - 4 (\vec D \cdot \vec D) (O' \cdot O' - r^2)}}{2 (\vec D \cdot \vec D)} \\\\
\end{gathered}
$$

Factoring out $2$ and $d$ from:

$$
\begin{gathered}
(2 O' \cdot \vec D d)^2 = 2^2 (O' \cdot \vec D) d^2 = 4 d^2 (O' \cdot \vec D)
\end{gathered}
$$

Therefore:

$$
\begin{aligned}
d &= \frac{- 2 O' \cdot \vec D d \pm \sqrt{4 d^2 (O' \cdot \vec D) - 4 (\vec D \cdot \vec D) (O' \cdot O' - r^2)}}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{- 2 O' \cdot \vec D d \pm \sqrt{4 ( d^2 (O' \cdot \vec D) - (\vec D \cdot \vec D) (O' \cdot O' - r^2))}}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{- 2 O' \cdot \vec D d \pm 2 \sqrt{d^2 (O' \cdot \vec D) - (\vec D \cdot \vec D) (O' \cdot O' - r^2)}}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{2 \left( - O' \cdot \vec D d \pm \sqrt{d^2 (O' \cdot \vec D) - (\vec D \cdot \vec D) (O' \cdot O' - r^2)} \right)}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{- d ( O' \cdot \vec D ) \pm \sqrt{d^2 (O' \cdot \vec D) - (\vec D \cdot \vec D) (O' \cdot O' - r^2)}}{\vec D \cdot \vec D} \\\\
d &= \frac{- d ( O' \cdot \vec D ) \pm \sqrt{d^2 (O' \cdot \vec D) - (\vec D \cdot \vec D) (O' \cdot O' - r^2)}}{\vec D \cdot \vec D} \\\\
\end{aligned}
$$

So the final formula is:

$$
d = \frac{- d ( O' \cdot \vec D ) \pm \sqrt{d^2 (O' \cdot \vec D) - (\Vert \vec D \Vert^2) (\Vert O' \Vert^2 - r^2)}}{\Vert \vec D \Vert^2}
$$

The part inside the square root is the discriminant and it determines how many real solutions the equation will have. Square Roots of negative numbers have no real solutions, so if the discriminant is negative the ray doesn't intersect the sphere at any point. If the discriminant is 0 it won't make a difference wether you add or substract the square root, so it will amount to 1 solution. If the discriminant is above 0 however, there will be 2 solutions depending on wether you subtract or add. The intersection closer to the rays origin can be found by subtracing and the one farther away by adding the root of the discriminant.