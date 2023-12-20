from data import gs, element_count
from WI_data import wi_index
from result_model import ResultModel


def create_table(gs_data):
    temp_table = []
    for i, column_g in enumerate(gs_data):
        row = []
        for j, row_g in enumerate(gs_data):
            row.append(round(column_g / row_g, 2))
        temp_table.append(row)
    return temp_table


def calculate_vi(table_data):
    temp_vis = []
    for row in table_data:
        result = 1
        for value in row:
            result *= value
        temp_vis.append(round(pow(result, 1 / 4), 3))
    return temp_vis


def calculate_pi(vis_data):
    vis_sum = sum(vis_data)
    temp_pis = [round(value / vis_sum, 3) for value in vis_data]
    return temp_pis


def calculate_en1(table_data, pis_data):
    en1_result = [sum(round(value * pis_data[index], 3) for index, value in enumerate(row)) for row in table_data]
    return en1_result


def calculate_en2(en1_data, pis_data):
    en2_result = [round(value / pis_data[index], 3) for index, value in enumerate(en1_data)]
    return en2_result


def main():
    table_data = create_table(gs)
    vis_data = calculate_vi(table_data)
    pis_data = calculate_pi(vis_data)
    en1_data = calculate_en1(table_data, pis_data)
    en2_data = calculate_en2(en1_data, pis_data)
    sum_en2 = sum(en2_data)
    lambda_max = round(sum_en2 / element_count, 1)
    IU = round((lambda_max - element_count) / (element_count - 1), 1)
    WI_value = wi_index[element_count]
    WU = IU / WI_value

    result_instance = ResultModel(table_data, vis_data, pis_data, en1_data, en2_data, lambda_max, IU, WI_value, WU)
    result_instance.show_result()


if __name__ == "__main__":
    main()
