namespace SimplexMethod {
    class Simplex {
        private int[,] tableau;
        private int numConstraints;
        private int numOriginalVariables;
        private int[] basis;

        public Simplex(int[,] table) {
            tableau = table;
            numConstraints = table.GetLength(0) - 1;
            numOriginalVariables = table.GetLength(1) - numConstraints - 1;
            basis = new int[numConstraints];
            for (int i = 0; i < numConstraints; i++)
                basis[i] = numOriginalVariables + i;
        }

        public int[,] Calculate(double[,] result) {
            while (true) {
                int pivotColumn = FindPivotColumn();
                if (pivotColumn == -1)
                    break;

                int pivotRow = FindPivotRow(pivotColumn);
                if (pivotRow == -1)
                    throw new Exception("Розв'язку немає.");

                ApplyPivot(pivotRow, pivotColumn);
                basis[pivotRow] = pivotColumn;
            }

            for (int i = 0; i < numOriginalVariables; i++) {
                result[i, 0] = tableau[numConstraints, i];
            }

            return tableau;
        }

        private int FindPivotColumn() {
            double minValue = 0;
            int minIndex = -1;
            for (int j = 0; j < tableau.GetLength(1) - 1; j++) {
                if (tableau[numConstraints, j] < minValue) {
                    minValue = tableau[numConstraints, j];
                    minIndex = j;
                }
            }
            return minIndex;
        }

        private int FindPivotRow(int pivotColumn) {
            double minRatio = double.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < numConstraints; i++) {
                if (tableau[i, pivotColumn] > 0) {
                    double ratio = (double)tableau[i, tableau.GetLength(1) - 1] / tableau[i, pivotColumn];
                    if (ratio < minRatio) {
                        minRatio = ratio;
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }

        private void ApplyPivot(int pivotRow, int pivotColumn) {
            for (int i = 0; i < tableau.GetLength(0); i++) {
                for (int j = 0; j < tableau.GetLength(1); j++) {
                    if (i != pivotRow && j != pivotColumn) {
                        tableau[i, j] -= tableau[pivotRow, j] * tableau[i, pivotColumn] / tableau[pivotRow, pivotColumn];
                    }
                }
            }

            for (int i = 0; i < tableau.GetLength(0); i++) {
                if (i != pivotRow) {
                    tableau[i, pivotColumn] = 0;
                }
            }

            for (int j = 0; j < tableau.GetLength(1); j++) {
                if (j != pivotColumn) {
                    tableau[pivotRow, j] /= tableau[pivotRow, pivotColumn];
                }
            }
            tableau[pivotRow, pivotColumn] = 1;
        }
    }
}
