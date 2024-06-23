import numpy as np

def little(matrix):
    cost_matrix = np.array(matrix, copy=True)
    n = len(cost_matrix)
    lower_bound = 0

    def reduce_rows(matrix, lower_bound):
        for i in range(len(matrix)):
            row_min = np.min(matrix[i])
            if row_min != np.inf:
                lower_bound += row_min
                matrix[i] -= row_min
        return matrix, lower_bound

    def reduce_columns(matrix, lower_bound):
        for i in range(len(matrix)):
            col_min = np.min(matrix[:, i])
            if col_min != np.inf:
                lower_bound += col_min
                matrix[:, i] -= col_min
        return matrix, lower_bound

    cost_matrix, lower_bound = reduce_rows(cost_matrix, lower_bound)
    cost_matrix, lower_bound = reduce_columns(cost_matrix, lower_bound)

    return cost_matrix, lower_bound

cost_matrix = [
    [np.inf, 20, 30, 10, 11],
    [15, np.inf, 16, 4, 2],
    [3, 5, np.inf, 2, 4],
    [19, 6, 18, np.inf, 3],
    [16, 4, 7, 16, np.inf]
]

reduced_matrix, lower_bound = little(cost_matrix)
print("Reduced cost matrix:")
print(reduced_matrix)
print("Lower bound:", lower_bound)
