class ResultModel:
    def __init__(self, table, vis, pis, en1, en2, lambda_max, IU, WI, WU):
        self.table = table
        self.vis = vis
        self.pis = pis
        self.en1 = en1
        self.en2 = en2
        self.lambda_max = lambda_max
        self.IU = IU
        self.WI = WI
        self.WU = WU

    def show_selected_results(self, selected_results=None):
        if selected_results is None:
            selected_results = ['table', 'vis', 'pis', 'en1', 'en2', 'lambda_max', 'IU', 'WI', 'WU']

        for result_type in selected_results:
            print(f'\n{self._format_result_type(result_type)})
            if result_type == 'table':
                self._show_table()
            elif hasattr(self, result_type):
                result_data = getattr(self, result_type)
                if isinstance(result_data, list):
                    for index, row in enumerate(result_data):
                        print(f'{self._format_group_label(index + 1)}{row}')
                else:
                    print(result_data)
            else:
                print(f'Error: Unknown result type - {result_type}')

    def _show_table(self):
        print('\tG1\t  G2\tG3\t  G4')
        for index, row in enumerate(self.table):
            print(f'{self._format_group_label(index + 1)}{row}')

    @staticmethod
    def _format_result_type(result_type):
        return f'{result_type.capitalize()}'

    @staticmethod
    def _format_group_label(group_number):
        return f'G{group_number}\t\t' if group_number < 4 else f'G{group_number}\t'
