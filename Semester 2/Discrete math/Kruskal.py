def kruskal(R):
    Rs = sorted(R, key=lambda x: x[0])

    U = set()
    D = {}
    T = []

    for r in Rs:
        if r[1] not in U or r[2] not in U:
            if r[1] not in U and r[2] not in U:
                D[r[1]] = [r[1], r[2]]
                D[r[2]] = D[r[1]]
            else:
                if not D.get(r[1]):
                    D[r[2]].append(r[1])
                    D[r[1]] = D[r[2]]
                else:
                    D[r[1]].append(r[2])
                    D[r[2]] = D[r[1]]

            T.append(r)
            U.add(r[1])
            U.add(r[2])

    for r in Rs:
        if r[2] not in D[r[1]]:
            T.append(r)
            gr1 = D[r[1]]
            D[r[1]] += D[r[2]]
            D[r[2]] += gr1

    return T

R_input = [(13, 1, 2), (18, 1, 3), (17, 1, 4), (14, 1, 5), (22, 1, 6),
           (26, 2, 3), (22, 2, 5), (3, 3, 4), (19, 4, 6)]
print(kruskal(R_input))

def main():
    R = []
    count = int(input("Сколько в вашем графе вершин?"))
    print("Введите данные о графе в виде кортежа в формате (вес, вершина1, вершина2)")
    for i in range(0, count-1):
        R.append(input())
    print(kruskal(R))
    
