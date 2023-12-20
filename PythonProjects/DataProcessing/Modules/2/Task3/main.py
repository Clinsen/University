import numpy as np
from sklearn.cluster import KMeans
import matplotlib.pyplot as plt

np.random.seed(42)
centers = [(-6, 0), (0, 6), (6, 0), (0, -6)]

data = []
for center in centers:
    cluster = np.random.randn(30, 2) + np.array(center)
    data.append(cluster)

data = np.concatenate(data, axis=0)

# Візуалізація
plt.scatter(data[:, 0], data[:, 1])
plt.title('Згенеровані дані')
plt.show()

# Навчання моделі
kmeans = KMeans(n_clusters=4, random_state=42)
kmeans.fit(data)

labels = kmeans.labels_

# Результати
plt.scatter(data[:, 0], data[:, 1], c=labels, cmap='viridis')
plt.scatter(kmeans.cluster_centers_[:, 0], kmeans.cluster_centers_[:, 1], s=300, c='red', marker='X', label='Центр кластера')
plt.title('K-Means Кластери')
plt.legend()
plt.show()
