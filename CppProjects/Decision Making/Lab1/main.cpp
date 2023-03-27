#include <iostream>
#include <vector>
#include "windows.h"

struct Relation
{
	std::vector< std::vector<int> > P
	{
		{	0, 1, 0, 0, 0	},
		{	0, 0, 1, 0, 1	},
		{	1, 0, 1, 0, 0	},
		{	1, 0, 0, 0, 1	},
		{	1, 1, 0, 1, 1	}
	};
	std::vector< std::vector<int> > Q
	{
		{	0, 1, 0, 1, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 1, 0, 1, 1	},
		{	1, 0, 0, 1, 1	},
		{	1, 0, 1, 1, 0	}
	};
	std::vector< std::vector<int> > R
	{
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	}
	};
	std::vector < std::vector<int> > result
	{
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	}
	};

	Relation()
	{
		int switch_choice;
		std::cout << "������� ��� ��������� ��� ������� R:\n"
			<< "1. ������\n"
			<< "2. �����\n"
			<< "3. ĳ���������\n"
			<< "4. ��������������\n"
			<< "������ ����� (1-4): ";
		std::cin >> switch_choice;

		switch (switch_choice)
		{
		case 1:
			std::cout << "������� ������ ���������. ���������� �������...\n";
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					R[i][j] = 0;
				}
			}
			break;

		case 2:
			std::cout << "������� ����� ���������. ���������� �������...\n";
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					R[i][j] = 1;
				}
			}
			break;

		case 3:
			std::cout << "������� ���������� ���������. ���������� �������...\n";
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (i == j)
					{
						R[i][j] = 1;
					}
					else
					{
						R[i][j] = 0;
					}
				}
			}
			break;

		case 4:
			std::cout << "������� �������������� ���������. ���������� �������...\n";
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (i != j)
					{
						R[i][j] = 1;
					}
					else
					{
						R[i][j] = 0;
					}
				}
			}
			break;

		default:
			std::cout << "���� ����� �� ����! ���������� ������� ������...\n";
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					R[i][j] = 0;
				}
			}
			break;

		}
	}

	void clear_result()
	{
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				result[i][j] = 0;
			}
		}
	}

	void compare_matrices()
	{
		int switch_compare;
		std::cout << "\n\n������� ���������: "
			<< "\n1. P �� Q"
			<< "\n2. P �� R"
			<< "\n3. Q �� R"
			<< "\n������ ����� (1-3): ";
		std::cin >> switch_compare;

		switch (switch_compare)
		{
		case 1:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] == Q[i][j])
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
				}
			}
			break;
		case 2:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] == R[i][j])
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
				}
			}
			break;
		case 3:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (Q[i][j] == R[i][j])
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
				}
			}
			break;
		default:
			std::cout << "This option doesn't exist!\n";
			exit(0);
		}
		// P ~ Q, P ~ R, Q ~ R
		
		std::cout << "\n\n���������:\n";
		for (unsigned int i = 0; i < result.size(); i++)
		{
			for (unsigned int j = 0; j < result.size(); j++)
			{
				std::cout << result[i][j] << " ";
				if (j == 4)
				{
					std::cout << "\n";
				}
			}
		}

		clear_result();

		std::cout << "\n\n�������� �������� ��� ��������� P �� Q:\n";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (P[i][j] == Q[i][j])
				{
					result[i][j] = 1;
				}
				else
				{
					result[i][j] = 0;
				}
			}
		}

		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				std::cout << result[i][j] << " ";
			}
			std::cout << "\n";
		}

		clear_result();

		std::cout << "\n\n�������� ��'������� ��� ��������� P �� Q:\n";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (P[i][j] == 1 || Q[i][j] == 1)
				{
					result[i][j] = 1;
				}
				else
				{
					result[i][j] = 0;
				}
			}
		}

		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				std::cout << result[i][j] << " ";
			}
			std::cout << "\n";
		}

		clear_result();

		std::cout << "\n\n�������� ������ ��� ��������� P �� Q:\n";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (P[i][j] != 1 && Q[i][j] != 1)
				{
					result[i][j] = 1;
				}
				else
				{
					result[i][j] = 0;
				}
			}
		}

		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				std::cout << result[i][j] << " ";
			}
			std::cout << "\n";
		}

		clear_result();

		std::cout << "\n\n�������� ���������� ������ ��� ��������� P �� Q:\n";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if ((P[i][j] == 1 || Q[i][j] == 1) != (P[i][j] == Q[i][j]))
				{
					result[i][j] = 1;
				}
				else
				{
					result[i][j] = 0;
				}
			}
		}
		
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				std::cout << result[i][j] << " ";
			}
			std::cout << "\n";
		}

		clear_result();
	}
};

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	Relation wswg;
	wswg.compare_matrices();
}