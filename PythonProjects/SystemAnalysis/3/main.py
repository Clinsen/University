from Model import TableModel
from data import aHat, ipHat, idHat, itHat

alpha_data = []
beta_data = []
gamma_data = []

ip_s_data = []
id_s_data = []
it_s_data = []


def calculate_alpha(value):
    return round(0.5 * (1 + value) ** 2 * (1 * value), 3)


def calculate_beta(a_hat, ip_hat, gamma_value):
    first_part = 1 + 0.7 * a_hat
    second_part = (1 + ip_hat) ** 2
    third_part = 10 ** -3 * gamma_value

    return first_part / second_part * third_part


def calculate_gamma(alpha_value):
    return 0.5 * (1 + alpha_value ** 2)


def calculate_ip(ip_hat_value, alpha_value, t_value):
    formula = ip_hat_value * (1 + alpha_value * t_value)
    if 0 < formula < 1:
        return 10 ** -2 * ip_hat_value * (1 + alpha_value * (t_value + 1) ** 2)
    return 1


def calculate_id(id_hat_value, gamma_value, t_value):
    formula = id_hat_value * (1 + gamma_value * t_value)
    if 0 < formula < 1:
        return 10 ** -1 * id_hat_value * (1 + gamma_value * (1 + t_value))
    return 1


def calculate_it(it_hat_value, beta_value, t_value):
    formula = beta_value * (t_value ** 2)
    if 0 < formula < 1:
        return 10 ** -1 * it_hat_value * (1 + (1 - beta_value * (t_value ** 2)))
    return 0


def tabulate_alpha():
    for row in ipHat:
        result_row = [calculate_alpha(value) if 0 < value <= 1 else 0 for value in row]
        alpha_data.append(result_row)


def tabulate_beta():
    for i, row in enumerate(aHat):
        result_row = [
            calculate_beta(value, ipHat[i][j], gamma_data[i][j]) if (value + ipHat[i][j] > 0) and (
                    value + ipHat[i][j] <= 1) else 0
            for j, value in enumerate(row)
        ]
        beta_data.append(result_row)


def tabulate_gamma():
    for row in alpha_data:
        result_row = [calculate_gamma(value) if 0 < value <= 1 else 0 for value in row]
        gamma_data.append(result_row)


def tabulate_s(s_num, result_list, hat_matrix, data_matrix, calculate_function, t_increment=0.5):
    t_value = 0
    for i in range(len(hat_matrix[s_num])):
        hat_value = hat_matrix[s_num][i]
        data_value = data_matrix[s_num][i]
        result = calculate_function(hat_value, data_value, t_value)
        result_list.append(result)
        t_value += t_increment


def run_s_tabulation():
    lists_s = [ip_s_data, id_s_data, it_s_data]

    for i in range(len(lists_s)):
        tabulate_s(i, lists_s[i], [ipHat, idHat, itHat], [alpha_data, gamma_data, beta_data],
                   [calculate_ip, calculate_id, calculate_it])


def show_all_results():
    table_names = ['Alpha', 'Beta', 'Gamma', 'Ip S', 'Id S', 'It S']
    data_lists = [alpha_data, beta_data, gamma_data, ip_s_data, id_s_data, it_s_data]

    for table_name, data_list in zip(table_names, data_lists):
        table_model = TableModel(table_name, data_list)
        table_model.show_result() if 'S' not in table_name else table_model.show_s_result()


tabulate_alpha()
tabulate_gamma()
tabulate_beta()
run_s_tabulation()
show_all_results()
