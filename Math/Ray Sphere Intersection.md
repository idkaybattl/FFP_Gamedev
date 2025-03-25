#### The Situation:
Given a ray and a sphere in 3-dimensional space we want to determine wether the ray intersects the sphere at any point.

#### Definitions:

$\vec O$ is the origin of the ray
$\vec D$ is the normalised Vector of the direction the ray is facing
$\vec H$ is a position along the ray
$d$ is distance
$\vec P$ is the position of the sphere
$r$ is the radius of the sphere

#### Known Formulae:

Sphere (assuming $P$ is $(0, 0, 0)$):

$$
\begin{gathered}
x^2 + y^2 + z^2 = r^2 \\\\\\
\vec H = \vec O + \vec D d
\end{gathered}
$$

Since $P$ has to be at $(0, 0, 0)$ for the Spehere‘s equation to work:
Going Foward:

$\vec P'$ is the adjusted position of the sphere
$\vec O'$ is the adjusted origin of the ray

$$
\vec P = \left( \begin{matrix} 0 \\ 0 \\ 0 \end{matrix} \right)
$$

and therefore:

$$
\vec O' = \vec O - \vec P
$$


#### Calculaion

Find a formula for $\vec H$ where it lies on the surface of the Sphere.
So:

$$
\begin{pmatrix} x \\ y \\ z \end{pmatrix} = \vec H
$$

according to Pythagoras the length $l$ of a vector $\vec V$ squared:

$$
l^2 = \Vert \vec V \Vert^2= \begin{Vmatrix} \begin{pmatrix} x \\ y \\ z \end{pmatrix} \end{Vmatrix}^2 = x^2 + b^2 + c^2
$$

Therefore:

$$
\begin{aligned}
\Vert \vec H \Vert^2 &= r^2 \\\\
\Vert (\vec O' + \vec D d) \Vert^2 &= r^2
\end{aligned}
$$

Since the Dot Product of a Vector $\vec V$ to itself is it’s squared length:

$$
\vec V \cdot \vec V = \Vert \vec V \Vert^2
$$

This is true:

$$
\begin{aligned}
(\vec O' + \vec D d) \cdot (\vec O' + \vec D d) &= r^2 \\\\
\vec O' \cdot \vec O' + \vec O' \cdot \vec D d + \vec O' \cdot \vec D d + \vec D d \cdot \vec D d &= r^2 \\\\
\vec O' \cdot \vec O' + 2 \vec O' \cdot \vec D d + \vec D \cdot \vec D d^2 &= r^2\\\\
\vec D \cdot \vec D d^2 + 2 \vec O' \cdot \vec D d + \vec O' \cdot \vec O' - r^2 &= 0
\end{aligned}
$$

Using the quadratic formula for d:

$$
\begin{aligned}
a &= \vec D \cdot \vec D \\\\
b &= 2 \vec O' \cdot \vec D d \\\\
c &= \vec O' \cdot \vec O' - r^2 \\\\\\
\end{aligned}
$$

$$
\begin{gathered}
d = \frac{-b \pm \sqrt{b^2 - 4 a c}}{2 a} \\\\
d = \frac{- 2 \vec O' \cdot \vec D d \pm \sqrt{(2 \vec O' \cdot \vec D d)^2 - 4 (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2)}}{2 (\vec D \cdot \vec D)} \\\\
\end{gathered}
$$

Factoring out $2$ and $d$ from:

$$
\begin{gathered}
(2 \vec O' \cdot \vec D d)^2 = 2^2 (\vec O' \cdot \vec D) d^2 = 4 d^2 (\vec O' \cdot \vec D)
\end{gathered}
$$

Therefore:

$$
\begin{aligned}
d &= \frac{- 2 \vec O' \cdot \vec D d \pm \sqrt{4 d^2 (\vec O' \cdot \vec D) - 4 (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2)}}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{- 2 \vec O' \cdot \vec D d \pm \sqrt{4 ( d^2 (\vec O' \cdot \vec D) - (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2))}}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{- 2 \vec O' \cdot \vec D d \pm 2 \sqrt{d^2 (\vec O' \cdot \vec D) - (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2)}}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{2 \left( - \vec O' \cdot \vec D d \pm \sqrt{d^2 (\vec O' \cdot \vec D) - (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2)} \right)}{2 (\vec D \cdot \vec D)} \\\\
d &= \frac{- d ( \vec O' \cdot \vec D ) \pm \sqrt{d^2 (\vec O' \cdot \vec D) - (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2)}}{\vec D \cdot \vec D} \\\\
d &= \frac{- d ( \vec O' \cdot \vec D ) \pm \sqrt{d^2 (\vec O' \cdot \vec D) - (\vec D \cdot \vec D) (\vec O' \cdot \vec O' - r^2)}}{\vec D \cdot \vec D} \\\\
\end{aligned}
$$

So the final formula is:

$$
d = \frac{- d ( \vec O' \cdot \vec D ) \pm \sqrt{d^2 (\vec O' \cdot \vec D) - (\Vert \vec D \Vert^2) (\Vert \vec O' \Vert^2 - r^2)}}{\Vert \vec D \Vert^2}
$$

The part inside the square root is the discriminant and it determines how many real solutions the equation will have. Square Roots of negative numbers have no real solutions, so if the discriminant is negative the ray doesn't intersect the sphere at any point. If the discriminant is 0 it won't make a difference wether you add or substract the square root, so it will amount to 1 solution. If the discriminant is above 0 however, there will be 2 solutions depending on wether you subtract or add. The intersection closer to the rays origin can be found by subtracing and the one farther away by adding the root of the discriminant.