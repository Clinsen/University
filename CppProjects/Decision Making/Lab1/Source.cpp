#include <iostream>
#include <vector>
#include <stdexcept>

class Matrix 
{
private:
    int size_;
    std::vector<int> data_;

public:
    Matrix(const std::vector<int>& data, int size) : size_(size), data_(data) 
    {
        if (data.size() != size_ * size_) 
        {
            throw std::invalid_argument("Invalid data size");
        }
    }

    int size() const 
    {
        return size_;
    }

    int get(int row, int col) const 
    {
        return data_[row * size_ + col];
    }

    Matrix intersection(const Matrix& other) const {
        if (size_ != other.size()) {
            throw std::invalid_argument("Matrices have different sizes");
        }
        std::vector<int> data;
        for (int i = 0; i < size_ * size_; i++) {
            data.push_back(data_[i] & other.data_[i]);
        }
        return Matrix(data, size_);
    }

    Matrix difference(const Matrix& other) const {
        if (size_ != other.size()) {
            throw std::invalid_argument("Matrices have different sizes");
        }
        std::vector<int> data;
        for (int i = 0; i < size_ * size_; i++) {
            data.push_back(data_[i] & ~other.data_[i]);
        }
        return Matrix(data, size_);
    }

    Matrix symmetric_difference(const Matrix& other) const {
        if (size_ != other.size()) {
            throw std::invalid_argument("Matrices have different sizes");
        }
        std::vector<int> data;
        for (int i = 0; i < size_ * size_; i++) {
            data.push_back(data_[i] != other.data_[i]);
        }
        return Matrix(data, size_);
    }

    Matrix addition(const Matrix& other) const {
        if (size_ != other.size()) {
            throw std::invalid_argument("Matrices have different sizes");
        }
        std::vector<int> data;
        for (int i = 0; i < size_ * size_; i++) {
            data.push_back(data_[i] | other.data_[i]);
        }
        return Matrix(data, size_);
    }

    Matrix composition(const Matrix& other) const {
        if (size_ != other.size()) {
            throw std::invalid_argument("Matrices have different sizes");
        }
        std::vector<int> data;
        for (int i = 0; i < size_; i++) {
            for (int j = 0; j < size_; j++) {
                int value = 0;
                for (int k = 0; k < size_; k++) {
                    value += get(i, k) * other.get(k, j);
                }
                data.push_back(value > 0 ? 1 : 0);
            }
        }
        return Matrix(data, size_);
    }

    friend std::ostream& operator<<(std::ostream& os, const Matrix& matrix) {
        for (int i = 0; i < matrix.size_; ++i) {
            for (int j = 0; j < matrix.size_; ++j) {
                os << matrix.data_[i * matrix.size_ + j] << " ";
            }
            os << std::endl;
        }
        return os;
    }
};

int main() 
{
    std::vector<int> data_q = {
        1, 0, 1, 0, 1,
        0, 1, 0, 1, 0,
        1, 0, 1, 0, 1,
        0, 1, 0, 1, 0,
        1, 0, 1, 0, 1
    };
    std::vector<int> data_p = {
        0, 1, 1, 1, 0,
        1, 0, 1, 0, 1,
        1, 1, 0, 1, 1,
        1, 0, 1, 0, 1,
        0, 1, 1, 1, 0
    };
    std::vector<int> data_r = {
        0, 0, 1, 1, 1,
        0, 0, 1, 1, 1,
        1, 1, 0, 1, 1,
        1, 1, 1, 0, 0,
        1, 1, 1, 0, 0
    };

    int size = 5;

    Matrix Q(data_q, size);
    Matrix P(data_p, size);
    Matrix R(data_r, size);

    Matrix QP = Q.intersection(P);
    std::cout << "Q intersection P:\n" << QP << std::endl;

    Matrix QR = Q.difference(R);
    std::cout << "Q difference R:\n" << QR << std::endl;

    Matrix PS = P.symmetric_difference(Q);
    std::cout << "P symmetric difference Q:\n" << PS << std::endl;

    Matrix QP_R = QP.addition(R);
    std::cout << "Q intersection (P + R):\n" << QP_R << std::endl;

    Matrix RP = R.composition(P);
    std::cout << "R composition P:\n" << RP << std::endl;

    return 0;
}