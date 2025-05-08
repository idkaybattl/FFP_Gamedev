import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d.art3d import Poly3DCollection
import numpy as np


# Define vertices of the triangle
A = np.array([0, 0, 0])
B = np.array([1, 0, 0])
C = np.array([0, 1, 1])

fig = plt.figure()
ax = fig.add_subplot(111, projection='3d')

# Create a list of the triangle's vertices
triangle = [A, B, C]
# Create a 3D polygon and add it to the plot
poly = Poly3DCollection([triangle], facecolors='cyan', edgecolors='black', linewidths=1, alpha=0.5)
ax.add_collection3d(poly)

# Extract x, y, z coordinates of the vertices
xs, ys, zs = zip(*triangle)
# Plot the vertices
ax.scatter(xs, ys, zs, color='blue', s=50, depthshade=False)

# Annotate each vertex
ax.text(*A, 'A', color='black', fontsize=12)
ax.text(*B, 'B', color='black', fontsize=12)
ax.text(*C, 'C', color='black', fontsize=12)


# Set axes limits
ax.set_xlim([min(A[0], B[0], C[0]) - 1, max(A[0], B[0], C[0]) + 1])
ax.set_ylim([min(A[1], B[1], C[1]) - 1, max(A[1], B[1], C[1]) + 1])
ax.set_zlim([min(A[2], B[2], C[2]) - 1, max(A[2], B[2], C[2]) + 1])

# Set labels
ax.set_xlabel('X')
ax.set_ylabel('Y')
ax.set_zlabel('Z')


plt.show()
