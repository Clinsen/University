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
	std::vector < std::vector<int> > result
	{
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
	};
	std::vector < std::vector<int> > result2
	{
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
		{	0, 0, 0, 0, 0	},
	};

	void check_relation_type()
	{
		int switch_choice = NULL;
		int current_num = 0;

		std::cout << "Select relation type to check:\n"
			<< "1. Reflexivity\n"
			<< "2. Non-reflexivity\n"
			<< "3. Symmetricity\n"
			<< "4. Non-symmetricity\n"
			<< "5. Transitivity\n"
			<< "6. Connectivity\n"
			<< "7. Weak connectivity\n"
			<< "Your choice (1-7): ";
		std::cin >> switch_choice;

		switch (switch_choice)
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
			output_result();
			clear_result();
			break;
		case 2:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] != Q[i][j])
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
				}
			}
			output_result();
			clear_result();
			break;
		case 3:
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
			output_result();
			clear_result();
			break;
		case 4:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] ==  1 && Q[i][j] == 1)
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
				}
			}
			output_result();
			clear_result();
			break;
		case 5:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] == current_num && current_num == Q[i][j])
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
					current_num = P[i][j];
				}
			}
			output_result();
			clear_result();
			break;
		case 6:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] == 1 && Q[i][j] == 1 || P[i][j] == 0 && Q[i][j] == 0)
					{
						result[i][j] = 1;
					}
					else
					{
						result[i][j] = 0;
					}
				}
			}
			output_result();
			clear_result();
			break;
		case 7:
			for (unsigned int i = 0; i < 5; i++)
			{
				for (unsigned int j = 0; j < 5; j++)
				{
					if (P[i][j] != Q[i][j])
					{
						result[i][j] = 0;
					}
					else
					{
						result[i][j] = 1;
					}
				}
			}
			output_result();
			clear_result();
			break;
		default:
			std::cout << "Such option doesn't exist!\n";
		}
	}

	bool check_for_tolerance()
	{
		std::cout << "\n\nCheck for tolerance: ";
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
				if (P[i][j] == result[i][j])
				{
					result2[i][j] = 1;
				}
				else
				{
					result2[i][j] = 0;
				}
			}
		}

		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (result[i][j] == result2[i][j])
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		clear_result();
	}

	bool check_for_equality()
	{
		std::cout << "\nCheck for equality: ";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (P[i][j] == Q[i][j] && (P[i][j] == 1 && Q[i][j] == 1) != (P[i][j] == Q[i][j]))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}

	bool check_for_quasorder()
	{
		std::cout << "\nCheck for quasorder: ";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (Q[i][j] == P[i][j] && (Q[i][j] == 1) != (P[i][j] == Q[i][j]))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}

	bool check_for_linear_order()
	{
		std::cout << "\nCheck for linear order: ";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				if (Q[i][j] == P[i][j] && (Q[i][j] == 1) != (P[i][j] == Q[i][j]) && (P[i][j] == 0 && Q[i][j] == 1))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}

	void find_accessibility()
	{

	}


	void clear_result()
	{
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				result[i][j] = 0;
				result2[i][j] = 0;
			}
		}
	}

	void output_result()
	{
		std::cout << "\n\n";
		for (unsigned int i = 0; i < 5; i++)
		{
			for (unsigned int j = 0; j < 5; j++)
			{
				std::cout << result[i][j] << " ";
			}
			std::cout << "\n";
		}
	}
};

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	Relation l2;
	l2.check_relation_type();

	std::cout << std::boolalpha;
	std::cout << l2.check_for_tolerance();
	std::cout << l2.check_for_equality();
	std::cout << l2.check_for_quasorder();
	std::cout << l2.check_for_linear_order() << "\n\n";

	l2.find_accessibility();
}