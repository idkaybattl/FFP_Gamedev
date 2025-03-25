### The Situation:

Given 3 points that form a triangle in 3-dimensional space and a ray pointing from an origin into a direction we need to know if the ray intersects the inside of the triangle at any point in space.

### Definitions:

##### Known:

$A$ is the position of one corner of the triangle

$B$ is the position of one other corner of the triangle

$C$ is the position of the other corner of the triangle

$O$ is the origin of the ray

$\vec D$ is the normalised direction of the ray

##### Unknown:

$d$ is the distance at which the ray intersects the triangle

$\vec N$ is the normal vector of the triangle (not normalised)

$P$ is the point where the ray intersects the plane the triangle lies on

### The Idea:

Calculate the plane that the triangle lies on and find the point $P$ where the ray intersects the plane. Then find out wether $P$ is inside the triangle.