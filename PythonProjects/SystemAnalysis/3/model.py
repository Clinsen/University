class TableModel:
    def __init__(self, table_name, data_list):
        self.table_name = table_name
        self.data_list = data_list

    def show_result(self):
        print(f'\n▰▰▰▰▰▰ Table {self.table_name} ▰▰▰▰▰▰')
        for row in self.data_list:
            print(row)

    def show_s_result(self):
        t_value = 0
        print(f'\n▰▰▰▰▰▰ Table {self.table_name} ▰▰▰▰▰▰')
        for index, row in enumerate(self.data_list):
            print(f'{t_value}: {row}')
            t_value += 0.5
