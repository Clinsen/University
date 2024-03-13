import numpy as np
from sklearn.decomposition import TruncatedSVD

num_users_per_group = 2
num_movies = 50

user_ratings = np.random.randint(1, 11, size=(num_users_per_group * num_movies, num_movies))

svd = TruncatedSVD(n_components=10, random_state=42)
svd.fit(user_ratings)

selected_group_index = 0
start_index = selected_group_index * num_users_per_group
end_index = (selected_group_index + 1) * num_users_per_group

selected_group_ratings = user_ratings[start_index:end_index]

user_ratings_predicted = svd.inverse_transform(svd.transform(selected_group_ratings))
user_ratings_predicted = np.clip(user_ratings_predicted, 1, 10)

recommendations = []

for user_id, predicted_ratings in enumerate(user_ratings_predicted):
    recommendations.extend([(i+1, predicted_ratings[i]) for i in range(num_movies)])

print("Рекомендовані фільми для перегляду:")
print("---------------------------------------------")
for movie_id, predicted_rating in sorted(recommendations, key=lambda x: x[1], reverse=True):
    print(f"Movie ID: {movie_id}, Передбачена оцінка: {predicted_rating}")
    if predicted_rating >= 9:
        print("Максимальна рекомендація до перегляду!")
    elif predicted_rating >= 7:
        print("Рекомендовано до перегляду.")
    elif predicted_rating >= 5:
        print("Може вас зацікавити.")
    else:
        print("Можливо це не найкраща ідея.")
    print("---------------------------------------------")
