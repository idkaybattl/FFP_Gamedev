### The Situation

Given 3 points that form a triangle in 3-dimensional space and a ray pointing from an origin into a direction we need to know if the ray intersects the inside of the triangle at any point in space.

### Definitions

##### Known

$A$ is the position of one corner of the triangle

$B$ is the position of one other corner of the triangle

$C$ is the position of the other corner of the triangle

$O$ is the origin of the ray

$\vec D$ is the normalised direction of the ray

##### Unknown

$d$ is the distance at which the ray intersects the triangle

$\vec N$ is the normal vector of the triangle (not normalised)

$P$ is the point where the ray intersects the plane the triangle lies on

### The Idea

Find the equation for the plane that the triangle lies on and find the point $P$ where the ray intersects the plane. Then find out wether $P$ is inside the triangle.

First of all, any point $P$ on the trajectory of the ray can be expressed like this:

$$
P = O + \vec R d
$$

For every value of $P$ that lies on the plane with $A$ being any point on the plane we can say:

$$
(P-A) \cdot \vec N = 0
$$

since any vector on the plane (in this case $P - A$) is perpendicular to the normal vector of the plane and the dot product of two perpendicular vectors is always 0.

To find $P$ we still need to find $d$ .
To do that we can insert the equation for $P$ as a point on the ray:

$$
\begin{aligned}
(O + \vec R d - A) \cdot \vec N &= 0 \\
O \cdot \vec N + \vec R d \cdot \vec N - A \cdot \vec N &= 0 \\
\end{aligned}
$$

isolating d:

$$
\begin{aligned}
O \cdot \vec N - A \cdot \vec N &= - \vec R d \cdot \vec N \\
A \cdot \vec N - O \cdot \vec N &= \vec R d \cdot \vec N \\
A \cdot \vec N - O \cdot \vec N &= d (\vec R \cdot \vec N) \\
\frac {A \cdot \vec N - O \cdot \vec N} {\vec R \cdot \vec N} &= d \\
\frac {\vec N \cdot (A - O)} {\vec R \cdot \vec N} &= d
\end{aligned}
$$

Now that we‘ve found $d$ we can calculate $P$ with it using the original Formula: $O + \vec R d$ 

With $P$ calculated we now need to find out wether it is in- or outside of the triangle. There are two approaches for this.

##### Approach 1

For this approach we‘ll be using the crossproduct and the normal of the plane.

##### Approach 2

For this approach we‘ll be converting $P$ into so-called baycentric coordinates.
